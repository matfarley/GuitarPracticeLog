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
        DataGridView table;

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
            int rowcount = table.Rows.Count;
            int colcount = table.Columns.Count;
            items = new String[rowcount, colcount];
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
                MessageBox.Show(ex.Message);
            }
        }

        public String[,] GetItems()
        {
            return items;
        }
    }
}

