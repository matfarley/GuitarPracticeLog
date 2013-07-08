using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization;


namespace PracticeLog
{
    class Schedule : ISerializable
    {
        private String[,] items;
        DataGridView table;

        public Schedule(DataGridView table)
        {
            this.table = table;
            SetItems();
        }

        public void SetItems()
        {
            int rowcount = table.Rows.Count;
            int colcount = table.Columns.Count;
            items = new String[rowcount, colcount];

            for (int row = 0; row < rowcount; row++)
            {
                for (int col = 0; col < colcount; col++)
                {
                    items[row, col] = table.Rows[row].Cells[col].Value.ToString();
                }
            }
        }

        public String[,] GetItems()
        {
            return items;
        }
    }
}

