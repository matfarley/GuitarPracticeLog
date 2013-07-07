using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace PracticeLog
{
    class Schedule  //Serializable?
    {
        String[,] items = null;

        public String[,] SetItems(DataGridView table)
        {
            int rowcount = table.Rows.Count;
            int colcount = table.Columns.Count;
            items = new String[rowcount, colcount];



            for (int row = 0; row < rowcount; row++)
            {


                for (int col = 0; col < colcount; col++)
                {
                    items[row, col] = table.Rows[row].Cells[col].Value.ToString();

                    //sw.Write(table.Rows[row].Cells[col].Value);
                    //               
                }
            }
                //           
                return items;
            }
        }
    }

