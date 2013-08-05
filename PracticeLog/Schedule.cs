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

    [Serializable()] 

    class Schedule : ISerializable
    {
        private String[,] items;
        DataGridView table = null;

        public Schedule(DataGridView table)
        {
            this.table = table;
            SetItems();
        }


        //Deserialization constructor
        public Schedule(SerializationInfo info, StreamingContext ctxt)
        {
            items = (String[,])info.GetValue("Items", typeof(String[,]));
        }

        //Serialisation function
        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            info.AddValue("Items", items);
        }


        public void SetItems()
        {
            //Uses nested for loops to save contents of the datagridview to a 2D array.  This will be serialised.
            //Seems to be a problem with adding  the final cell - it throws a null pointer reference.
            int rowcount = table.Rows.Count;
            int colcount = table.Columns.Count;
            items = new String[rowcount, colcount];
            Console.WriteLine();
            try
            {
                for (int row = 0; row < rowcount; row++)
                {
                    for (int col = 0; col < colcount; col++)
                    {
                        items[row, col] = table.Rows[row].Cells[col].Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("problems start here: Line 47 \r\n" + ex.Message);
            }
        }

        public String[,] GetItems()
        {
            return items;
        }
    }
}

