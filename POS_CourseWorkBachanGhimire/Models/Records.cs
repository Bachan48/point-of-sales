using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_CourseWorkBachanGhimire.Models
{
    class Records
    {
        public string ItemName { get; set; }
        public string Category { get; set; }
        public double? Price { get; set; }

        public Records(string itemName, string category, double price)
        {
            ItemName = itemName;
            Category = category;
            Price = price;
        }

        public void AddToRecords(int RowIndex, DataGridView DataGridView)
        {
            DataGridView.Rows.Add();
            DataGridView.Rows[RowIndex].Cells[0].Value = ItemName;
            DataGridView.Rows[RowIndex].Cells[1].Value = Category;
            DataGridView.Rows[RowIndex].Cells[2].Value = Price;
        }

        public void DeleteRecords(DataGridView DataGridView)
        {
            foreach (DataGridViewRow row in DataGridView.SelectedRows)
            {
                DataGridView.Rows.RemoveAt(row.Index);
            }
            MessageBox.Show("Selected record deleted.", "Record deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ItemName = null;
            Category = null;
            Price = null;
        }

    }
}
