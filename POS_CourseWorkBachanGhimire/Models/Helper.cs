using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_CourseWorkBachanGhimire.Models
{
    class Helper
    {
        public int GetEmptyRowIndex()
        {
            int rows = POSForm.RecordsGridView.RowCount;
            int columns = POSForm.RecordsGridView.ColumnCount;
            int nextRow = 0;
            int nextCol = 0;
            bool flag = false;
            do
            {
                string value = (string)POSForm.RecordsGridView.Rows[nextRow].Cells[nextCol].Value;
                if (value != null && value.Length != 0) nextRow++;
                else flag = true;
            } while (!flag && nextRow < rows);
            return nextRow;
        }

    }
}
