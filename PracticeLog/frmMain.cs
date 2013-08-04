using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace PracticeLog
{
    public partial class frmMain : Form
    {
        private String[] PracticeAreas;
        private Model ScheduleModel;
        private int RowIndex;
        private string CurrentFile = "";

        
        public frmMain()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void newPracticeScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ScheduleModel.NewSchedule(CurrentFile);

        }

        private void mnuSaveAs_Click(object sender, EventArgs e)
        {
            //The file extension for practice schedules is .ps
            savDialog.Filter = "Practice Schedule Files (*.ps)|*.ps";
            savDialog.ShowDialog();
          
            CurrentFile = savDialog.FileName;
            
            ScheduleModel.SaveScheduleSerialise(CurrentFile);

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Need to add a check to see a selection has been made, otherwise send back an message
            
            CopyItemToTable();

        }

        public void CopyItemToTable()
        {
            if (cboArea.SelectedItem != null)
            {
                RowIndex = tblSchedule.Rows.Count;

                int index = tblSchedule.Rows.Add();

                DataGridViewRow row = tblSchedule.Rows[index];

                row.Cells[0].Value = cboArea.SelectedItem;
                row.Cells[1].Value = txtItem.Text;
                row.Cells[2].Value = numMins.Value;
                row.Cells[3].Value = numSecs.Value;
                row.Cells[4].Value = "0:00";

                //Clear selections
                cboArea.SelectedItem = null;
                txtItem.Text = "";
                numMins.Value = 0;
                numSecs.Value = 0;
            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            ScheduleModel.RemoveRow();
        }


        private void frmMain_Load(object sender, EventArgs e)
        {
            ScheduleModel = new Model(tblSchedule, savDialog, opnDialog);

            PracticeAreas = new String[] { "Technique", "Fretboard Knowledge", "Musicianship", "Repitoire Vocabulary", "Review", "Success Mindset" };
            foreach (String area in PracticeAreas)
            {
                cboArea.Items.Add(area);

            }
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
           
            ScheduleModel.SaveScheduleSerialise(CurrentFile);
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            
            opnDialog.Filter = "Practice Schedule Files (*.ps)|*.ps";
            opnDialog.ShowDialog();
            CurrentFile = opnDialog.FileName;
            
            ScheduleModel.OpenScheduleSerialise(CurrentFile);

            }

        }
    }

