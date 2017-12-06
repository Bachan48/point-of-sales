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

namespace POS_CourseWorkBachanGhimire
{
    public partial class POSForm : Form
    {
        public POSForm()
        {
            InitializeComponent();
            MaximizeBox = false;
            foreach (DataGridViewColumn column in RecordsGridView.Columns)
            {
                column.ReadOnly = true;
            }
            RecordsGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            billingTotal.ReadOnly = true;

        }


        //add buttom clicked
        private void addButton_Click(object sender, EventArgs e)
        {
            string ItemName = this.itemName.Text.Trim();
            string Category = category.Text.Trim();            

            try
            {
                double Price = Convert.ToDouble(price.Text);
                if (ItemName != null && ItemName != "" && Category != null && Category != "")
                {
                    Helper helper = new Helper();
                    int RowIndex = helper.GetEmptyRowIndex();
                    ItemRecords itemRecords = new ItemRecords(ItemName, Category, Price);
                    itemRecords.AddToRecords(RowIndex);
                    itemName.Text = "";
                    price.Text = "";
                }
                else
                {
                    MessageBox.Show("Please fill up all fields.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid Price.");
            }          
        }


        //delete button clicked
        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (RecordsGridView.SelectedRows.Count > 0)
                {   
                    foreach (DataGridViewRow row in RecordsGridView.SelectedRows)
                    {
                        RecordsGridView.Rows.RemoveAt(row.Index);
                    }
                    MessageBox.Show("Selected rows deleted");
                    
                }
                else MessageBox.Show("Select a row before deleting.");
               
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Default row can't be deleted.");
            }
            
        }


        //browse button clicked
        private void browseButton_Click(object sender, EventArgs e)
        {

        }
    }
}
