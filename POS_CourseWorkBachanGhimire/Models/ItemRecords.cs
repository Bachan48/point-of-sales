using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_CourseWorkBachanGhimire.Models
{
    class ItemRecords
    {
        public string ItemName { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }

        public ItemRecords(string itemName, string category, double price)
        {
            ItemName = itemName;
            Category = category;
            Price = price;
        }

        public void AddToRecords(int RowIndex)
        {
            POSForm.RecordsGridView.Rows.Add();
            POSForm.RecordsGridView.Rows[RowIndex].Cells[0].Value = ItemName;
            POSForm.RecordsGridView.Rows[RowIndex].Cells[1].Value = Category;
            POSForm.RecordsGridView.Rows[RowIndex].Cells[2].Value = Price;

        }
    }
}
