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
                            SaveScheduleSerialise(CurrentFile);
                            ApplicationTable.Rows.Clear();
                        }
                        else
                        {
                            savDialog.Filter = "Practice Schedule Files (*.ps)|*.ps";
                            savDialog.ShowDialog();
                            SaveScheduleSerialise(savDialog.FileName);
                        }
                        break;
                    case DialogResult.No:
                        ApplicationTable.Rows.Clear();
                        break;
                }
            }

        }

       

        //Trying to use serialisation to Save and open - at the moment it is Giving a null reference exception and I am not sure why
        public void SaveScheduleSerialise(String CurrentFile)
        {
            if (CurrentFile != "" && CurrentFile != null)
            {
                s1 = new Schedule(ApplicationTable);
                try
                {
                    Stream stream = File.Open(CurrentFile, FileMode.Create);
                    BinaryFormatter bformatter = new BinaryFormatter();
               
                    Console.WriteLine("Writing practice schedule"); // Output message used for debugging
                    bformatter.Serialize(stream, s1);
                    stream.Close();
                    s1 = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show( ex.ToString());
                }
            }

        }

        // Attempting to load a serialised object
        public void OpenScheduleSerialise(String CurrentFile)
        {
            if (CurrentFile != "" && CurrentFile != null)
            {
                try
                {
                    stream = File.Open(CurrentFile, FileMode.Open);
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

        }

       
    }


}
