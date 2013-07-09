using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;



namespace PracticeLog
{
    class Model
    {
        private StreamWriter sw;
        private TextReader tr;
        private DataGridView ApplicationTable;
        SaveFileDialog savDialog;
        OpenFileDialog opnDialog;
        private Schedule s1;
       private Stream stream;



        public Model(DataGridView ApplicationTable, SaveFileDialog savDialog, OpenFileDialog opnDialog)
        {
            this.ApplicationTable = ApplicationTable;
            this.savDialog = savDialog;
            this.opnDialog = opnDialog;
        }

        public void RemoveRow()
        {
            foreach (DataGridViewCell cell in ApplicationTable.SelectedCells)
            {
                ApplicationTable.Rows.Remove(ApplicationTable.Rows[cell.RowIndex]);
            }
        }

        public void NewSchedule(String CurrentFile)
        {
            if (ApplicationTable.Rows.Count != 0)
            {
                DialogResult msgSelection = MessageBox.Show("Do you want to save the current Practice Schedule?", "Save Practice Schedule", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                switch (msgSelection)
                {
                    case DialogResult.Yes:
                        if (CurrentFile != "")
                        {
                            saveSchedule(CurrentFile);
                            ApplicationTable.Rows.Clear();
                        }
                        else
                        {
                            savDialog.Filter = "CSV Files (*.csv)|*.csv";
                            savDialog.ShowDialog();
                            saveSchedule(savDialog.FileName);
                        }
                        break;
                    case DialogResult.No:
                        ApplicationTable.Rows.Clear();
                        break;
                }
            }

        }

        public void saveSchedule(String path)
        {
            if (path != "")
            {
                try
                {

                    sw = new StreamWriter(path, false);



                    int count = ApplicationTable.Rows.Count;
                    int colcount = ApplicationTable.Columns.Count;

                    for (int row = 0; row < count; row++)
                    {


                        for (int col = 0; col < colcount; col++)
                        {
                            sw.Write(ApplicationTable.Rows[row].Cells[col].Value + ",");
                            ;
                        }
                        sw.Write("\r\n");

                    }
                    sw.Close();
                    sw.Dispose();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //Trying to use serialisation to Save and open
        public void SaveScheduleSerialise()
        {

            s1 = new Schedule(ApplicationTable);
<<<<<<< HEAD
            Stream stream = File.Open("Practice1.ps", FileMode.Create);
            BinaryFormatter bformatter = new BinaryFormatter();

           //Output message
            Console.WriteLine("Writing practice schedule");
            bformatter.Serialize(stream, s1);
            stream.Close();
            s1 = null;

        }

        // Attempting to load a serialised object
        public void OpenScheduleSerialise()
        {

            stream = File.Open("Practice1.ps", FileMode.Open);
            BinaryFormatter bformatter = new BinaryFormatter();
           
            s1 = (Schedule)bformatter.Deserialize(stream);
            stream.Close();

            int rowcount = s1.GetItems().GetLength(0);
            int colcount = s1.GetItems().GetLength(1);

            ApplicationTable.Rows.Add(rowcount);

            for (int row = 0; row < rowcount; row++)
            {
                for (int col = 0; col < colcount; col++)
                {
                    ApplicationTable.Rows[row].Cells[col].Value = s1.GetItems()[row, col];
                }
            }
=======
            
>>>>>>> d47d64267d57730902bf07f96ed0ece0a12cae7e

        }

        public void OpenSchedule(String CurrentFile)
        {
            ApplicationTable.Rows.Clear();

            if (CurrentFile != "" && CurrentFile != null)
            {
                tr = File.OpenText(CurrentFile);

                try
                {

                    while (tr.Peek() != null)
                    {

                        ApplicationTable.Rows.Add(tr.ReadLine().Split(new char[] { ',' }));
                    }
                    tr.Close();
                    tr.Dispose();

                }
                catch (Exception ex)
                {
                }
            }
        }
    }


}
