using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;



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
            //string teststring1 = "";

            
            s1 = new Schedule();
            s1.SetItems(ApplicationTable);

            //for (int row = 0; row < ApplicationTable.Rows.Count; row++)
            //{
            //    for (int col = 0; col < ApplicationTable.Columns.Count; col++)
            //    {
            //        teststring1 += s1.SetItems(ApplicationTable)[row, col] + ", ";
            //    }
            //}

            //MessageBox.Show(teststring1);
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
