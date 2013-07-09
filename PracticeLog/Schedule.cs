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
<<<<<<< HEAD
    [Serializable()] 
=======
>>>>>>> d47d64267d57730902bf07f96ed0ece0a12cae7e
    class Schedule : ISerializable
    {
        private String[,] items;
        DataGridView table;

        public Schedule(DataGridView table)
        {
            this.table = table;
            SetItems();
        }
<<<<<<< HEAD

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
=======
>>>>>>> d47d64267d57730902bf07f96ed0ece0a12cae7e

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

