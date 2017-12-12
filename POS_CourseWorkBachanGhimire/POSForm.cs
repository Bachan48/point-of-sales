using POS_CourseWorkBachanGhimire.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;

namespace POS_CourseWorkBachanGhimire
{
    public partial class POSForm : Form
    {
        private ItemRecords itemRecords;
        private SalesRecords salesRecords;
        private Helper helper = new Helper();

        //form constructor
        public POSForm()
        {
            InitializeComponent();
            MaximizeBox = false;
            SalesGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            RecordsGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            RecordsGridView.ReadOnly = true;
            SalesGridView.ReadOnly = true;
            

            billingCategory.SelectedValueChanged +=
                new EventHandler(CategoryBox_SelectedValueChanged);
        }
     

        //add buttom clicked
        private void AddButton_Click(object sender, EventArgs e)
        {
            string ItemName = this.itemName.Text.Trim();
            string Category = category.Text.Trim();            

            try
            {
                double Price = Convert.ToDouble(price.Text);
                if (ItemName != null && ItemName != "" && Category != null && Category != "" && Price >=0)
                {                   
                    int RowIndex = helper.GetEmptyRowIndex(RecordsGridView);

                    //create new instance of ItemRecords
                    itemRecords = new ItemRecords(ItemName, Category, Price);
                    itemRecords.AddToRecords(RowIndex, RecordsGridView);

                    helper.ClearFields(itemName, price);
                    MessageBox.Show("Record has successfully been added.", "Records Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please fill up all fields properly.", "Fields Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid Price.", "Invalid Price", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }          
        }


        //delete button clicked
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (RecordsGridView.SelectedRows.Count > 0)
                    itemRecords.DeleteRecords(RecordsGridView);
                else
                    MessageBox.Show("Select a row before deleting.", "No rows selected", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception)
            {
                MessageBox.Show("Default row can't be deleted.", "Invalid row selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //browse button clicked
        private void BrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "Files(*.txt,*.csv)|*txt;*csv"
            };
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                fileLocation.Text = dialog.FileName;
            }
        }


        //clear location button clicked
        private void ClearButton_Click(object sender, EventArgs e)
        {
            helper.ClearFields(fileLocation);
        }


        //import button clicked
        private void ImportButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (fileLocation.Text != null && fileLocation.Text != "")
                {
                    TextFieldParser csvceader = new TextFieldParser(fileLocation.Text);
                    csvceader.SetDelimiters(new string[] { "," });
                    while (!csvceader.EndOfData)
                    {
                        string[] rowdata = csvceader.ReadFields();
                        //create new instance of itemRecords and pass row index and grid to AddToRecords
                        itemRecords = new ItemRecords(rowdata[0], rowdata[1], (Convert.ToDouble(rowdata[2])));
                        int rowIndex = helper.GetEmptyRowIndex(RecordsGridView);
                        itemRecords.AddToRecords(rowIndex, RecordsGridView);
                        helper.ClearFields(fileLocation);
                    }
                    MessageBox.Show("Records have successfully been imported.", "Records Imported", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("File location not specified.", "No Filepath selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            

            }
            catch (Exception ex)
            {
                MessageBox.Show("One or more records couldn't be imported. " + ex.Message, "Couldn't import record", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //sort button clicked
        private void Sort_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedItem = (string)sortBy.SelectedItem;
                if (selectedItem.Equals("Name"))
                {
                    helper.SortByName(RecordsGridView, ItemNameColumn.Index);
                }
                else if (selectedItem.Equals("Price"))
                {
                    helper.SortByPrice(RecordsGridView, ItemPriceColumn.Index);
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No sort method selected", "Couldn't sort", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //add to sales button clicked
        private void AddToSalesButton_Click(object sender, EventArgs e)
        {
           try
            {
                string ItemName = this.billingName.Text;
                string Category = this.billingCategory.Text;
                int Quantity = Convert.ToInt32(billingQuantity.Text);
                double Price = helper.GetPrice(RecordsGridView, ItemName, ItemNameColumn.Index, ItemPriceColumn.Index);
                if (ItemName != null && ItemName != "" && Category != null && Category != "" && Quantity >= 0)
                {                  

                    //create new instance of SalesRecords
                    for(int i=1; i<=Quantity; i++)
                    {
                        int RowIndex = helper.GetEmptyRowIndex(SalesGridView);
                        salesRecords = new SalesRecords(ItemName, Category, Price);
                        salesRecords.AddToRecords(RowIndex, SalesGridView);
                    }
                    MessageBox.Show("Given items has been sold", "Item Sold", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    helper.ClearFields(billingQuantity);

                    GenerateChart();
                }
                else
                {
                    MessageBox.Show("Please fill up all fields properly.", "Fields Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid quantity.", "Invalid quantity", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // value of selected item in category within billing changed
        private void CategoryBox_SelectedValueChanged(object sender, EventArgs e)
        {            
            string selectedCategory = (string)billingCategory.SelectedItem;
            helper.CategorizeMenuItem(RecordsGridView, billingName, CategoryColumn.Index, ItemNameColumn.Index, selectedCategory);
        }


        //Generate chart for sales report
        public void GenerateChart()
        {
            helper.ClearChart(SalesChart, "SalesSeries");

            double totalSalesBreakfastCategory;
            double totalSalesDrinksCategory;
            double totalSalesSnacksCategory;
            double totalSalesMealCategory;

            List<double> breakfastSoldPriceList = new List<double>();
            List<double> drinksSoldPriceList = new List<double>();
            List<double> snacksSoldPriceList = new List<double>();
            List<double> mealSoldPriceList = new List<double>();

            foreach (DataGridViewRow row in SalesGridView.Rows)
            {
                string category = Convert.ToString(row.Cells[SalesCategoryColumn.Index].Value);
                if (category.Equals("Breakfast"))
                {
                    double price= Convert.ToDouble(row.Cells[SalesPriceColumn.Index].Value);
                    breakfastSoldPriceList.Add(price);
                }
                else if (category.Equals("Drinks"))
                {
                    double price = Convert.ToDouble(row.Cells[SalesPriceColumn.Index].Value);
                    drinksSoldPriceList.Add(price);
                }
                else if (category.Equals("Snacks"))
                {
                    double price = Convert.ToDouble(row.Cells[SalesPriceColumn.Index].Value);
                    snacksSoldPriceList.Add(price);
                }
                else if (category.Equals("Meal"))
                {
                    double price = Convert.ToDouble(row.Cells[SalesPriceColumn.Index].Value);
                    mealSoldPriceList.Add(price);
                }
            }

            totalSalesBreakfastCategory = helper.GetTotalSales(breakfastSoldPriceList);
            totalSalesDrinksCategory = helper.GetTotalSales(drinksSoldPriceList);
            totalSalesSnacksCategory = helper.GetTotalSales(snacksSoldPriceList);
            totalSalesMealCategory = helper.GetTotalSales(mealSoldPriceList);

            helper.AddDataToChart(SalesChart, "SalesSeries", 0, totalSalesBreakfastCategory, "Breakfast", Color.Red);
            helper.AddDataToChart(SalesChart, "SalesSeries", 1, totalSalesDrinksCategory, "Drinks", Color.Green);
            helper.AddDataToChart(SalesChart, "SalesSeries", 2, totalSalesSnacksCategory, "Snacks", Color.LightSkyBlue);
            helper.AddDataToChart(SalesChart, "SalesSeries", 3, totalSalesMealCategory, "Meal", Color.Yellow);            
        }
    }
}
