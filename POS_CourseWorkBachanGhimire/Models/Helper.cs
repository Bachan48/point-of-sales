using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_CourseWorkBachanGhimire.Models
{
    /// <summary>
    /// A helper class for the algorithms to be implemented by the windows form
    /// Algorithms here are called in accordance to the event handling
    /// </summary>
    class Helper
    {
        /// <summary>
        /// This methods returns the index of empty row in sequence in data grid view
        /// </summary>
        /// <param name="DataGridView"></param>
        /// <returns></returns>
        public int GetEmptyRowIndex(DataGridView DataGridView)
        {
            int rows = DataGridView.RowCount;
            int columns = DataGridView.ColumnCount;
            int nextRow = 0;
            int nextCol = 0;
            bool flag = false;
            do
            {
                string value = (string)DataGridView.Rows[nextRow].Cells[nextCol].Value;
                if (value != null && value.Length != 0) nextRow++;
                else flag = true;
            } while (!flag && nextRow < rows);
            return nextRow;
        }

        public void ClearFields(TextBox box1)
        {
            box1.Text = "";
        }

        public void ClearFields(TextBox box1, TextBox box2)
        {
            box1.Text = "";
            box2.Text = "";
        }

        public void ClearFields(TextBox box1, TextBox box2, TextBox box3)
        {
            box1.Text = "";
            box2.Text = "";
            box3.Text = "";
        }

        /// <summary>
        /// Sorting algorithm for the data grid view. 
        /// Sorts the view by price.
        /// </summary>
        /// <param name="dataGridView"></param>
        /// <param name="priceColumnIndex"></param>
        public void SortByPrice(DataGridView dataGridView, int priceColumnIndex) 
        {
            List<double> prices = new List<double>();
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                double price= Convert.ToDouble(row.Cells[priceColumnIndex].Value);
                prices.Add(price);
            }
            for(int i=0; i < prices.Count-1; i++)
            {
                for(int j=1; j<prices.Count-1; j++)
                {
                    if (prices[j]<prices[j-1])
                    {
                        //sorting prices List only
                        double temp = prices[j - 1];
                        prices[j - 1] = prices[j];
                        prices[j] = temp;

                        List<Object> row0Items = new List<Object>();
                        List<Object> row1Items = new List<Object>();                        

                        //sorting the entire rows
                        for (int k=0; k<dataGridView.ColumnCount; k++)
                        {
                            Object item0 = dataGridView.Rows[j-1].Cells[k].Value;
                            Object item1 = dataGridView.Rows[j].Cells[k].Value;
                            row0Items.Add(item0);
                            row1Items.Add(item1);
                            dataGridView.Rows[j - 1].Cells[k].Value = row1Items[k];
                            dataGridView.Rows[j].Cells[k].Value = row0Items[k];
                        }                        
                    }
                }               
            }                
        }

        /// <summary>
        /// Sorting algorithm for the data grid view. 
        /// Sorts the view by item name.
        /// </summary>
        /// <param name="dataGridView"></param>
        /// <param name="NameColumnIndex"></param>
        public void SortByName(DataGridView dataGridView, int NameColumnIndex)
        {
            List<string> names = new List<string>();
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                string name = Convert.ToString(row.Cells[NameColumnIndex].Value);
                names.Add(name);
            }

            for (int i = 0; i < names.Count - 1; i++)
            {
                for (int j = 1; j < names.Count - 1; j++)
                {
                    if (true)
                    {
                        List<Object> row0Items = new List<Object>();
                        List<Object> row1Items = new List<Object>();
                        //sorting the entire rows
                        for (int k = 0; k < dataGridView.ColumnCount; k++)
                        {
                            Object item0 = dataGridView.Rows[j - 1].Cells[k].Value;
                            Object item1 = dataGridView.Rows[j].Cells[k].Value;
                            row0Items.Add(item0);
                            row1Items.Add(item1);
                            dataGridView.Rows[j - 1].Cells[k].Value = row1Items[k];
                            dataGridView.Rows[j].Cells[k].Value = row0Items[k];
                        }
                    }
                }
            }
        }


        /// <summary>
        /// Categorizes menu items according to their category in the menu
        /// </summary>
        /// <param name="dataGridView"></param>
        /// <param name="itemBox"></param>
        /// <param name="categoryIndex"></param>
        /// <param name="nameIndex"></param>
        /// <param name="selectedCategory"></param>
        public void CategorizeMenuItem(DataGridView dataGridView, ComboBox itemBox, int categoryIndex, int nameIndex, string selectedCategory)
        {
            List<Object> itemsList = new List<Object>();
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                string categoryName = Convert.ToString(row.Cells[categoryIndex].Value);
                if (categoryName.Equals(selectedCategory))
                {
                    string itemName = Convert.ToString(row.Cells[nameIndex].Value);
                    itemsList.Add(itemName);
                }
            }
            itemBox.DataSource = itemsList;
        }

        public double GetPrice(DataGridView dataGridView, string itemName, int nameColumnIndex, int priceColumnIndex)
        {
            
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                string name = Convert.ToString(row.Cells[nameColumnIndex].Value);
                if (name.Equals(itemName))
                {
                    return Convert.ToDouble(row.Cells[priceColumnIndex].Value);                   
                }
            }
            return -1;

        }
    }
}
