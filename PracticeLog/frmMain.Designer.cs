namespace PracticeLog
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tmrCountDown = new System.Windows.Forms.Timer(this.components);
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.newPracticeScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savDialog = new System.Windows.Forms.SaveFileDialog();
            this.opnDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnRemove = new System.Windows.Forms.Button();
            this.tblSchedule = new System.Windows.Forms.DataGridView();
            this.colPracticeArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPracticeItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTimeMins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSecs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tblPracticeItems = new System.Windows.Forms.TableLayoutPanel();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.cboArea = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numMins = new System.Windows.Forms.NumericUpDown();
            this.numSecs = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mnuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblSchedule)).BeginInit();
            this.tblPracticeItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSecs)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(845, 24);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "mnuMain";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPracticeScheduleToolStripMenuItem,
            this.mnuOpen,
            this.mnuSave,
            this.mnuSaveAs,
            this.exitToolStripMenuItem});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // newPracticeScheduleToolStripMenuItem
            // 
            this.newPracticeScheduleToolStripMenuItem.Name = "newPracticeScheduleToolStripMenuItem";
            this.newPracticeScheduleToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.newPracticeScheduleToolStripMenuItem.Text = "&New Practice Schedule...";
            this.newPracticeScheduleToolStripMenuItem.Click += new System.EventHandler(this.newPracticeScheduleToolStripMenuItem_Click);
            // 
            // mnuOpen
            // 
            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.Size = new System.Drawing.Size(208, 22);
            this.mnuOpen.Text = "&Open Practice Schedule...";
            this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // mnuSave
            // 
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.Size = new System.Drawing.Size(208, 22);
            this.mnuSave.Text = "&Save";
            this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // mnuSaveAs
            // 
            this.mnuSaveAs.Name = "mnuSaveAs";
            this.mnuSaveAs.Size = new System.Drawing.Size(208, 22);
            this.mnuSaveAs.Text = "Save & As...";
            this.mnuSaveAs.Click += new System.EventHandler(this.mnuSaveAs_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(634, 50);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(95, 23);
            this.btnRemove.TabIndex = 10;
            this.btnRemove.Text = "&Remove Item";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // tblSchedule
            // 
            this.tblSchedule.AllowUserToAddRows = false;
            this.tblSchedule.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tblSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPracticeArea,
            this.colPracticeItem,
            this.colTimeMins,
            this.colSecs,
            this.colTotalTime,
            this.colNotes});
            this.tblSchedule.Location = new System.Drawing.Point(12, 75);
            this.tblSchedule.MultiSelect = false;
            this.tblSchedule.Name = "tblSchedule";
            this.tblSchedule.RowHeadersVisible = false;
            this.tblSchedule.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tblSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.tblSchedule.Size = new System.Drawing.Size(822, 229);
            this.tblSchedule.TabIndex = 9;
            this.tblSchedule.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblSchedule_CellContentClick);
            // 
            // colPracticeArea
            // 
            this.colPracticeArea.HeaderText = "Practice Area";
            this.colPracticeArea.Name = "colPracticeArea";
            this.colPracticeArea.Width = 131;
            // 
            // colPracticeItem
            // 
            this.colPracticeItem.HeaderText = "Practice Item";
            this.colPracticeItem.Name = "colPracticeItem";
            this.colPracticeItem.Width = 273;
            // 
            // colTimeMins
            // 
            this.colTimeMins.HeaderText = "Mins.";
            this.colTimeMins.Name = "colTimeMins";
            this.colTimeMins.Width = 57;
            // 
            // colSecs
            // 
            this.colSecs.HeaderText = "Secs.";
            this.colSecs.Name = "colSecs";
            this.colSecs.Width = 57;
            // 
            // colTotalTime
            // 
            this.colTotalTime.HeaderText = "Total Time";
            this.colTotalTime.Name = "colTotalTime";
            // 
            // colNotes
            // 
            this.colNotes.HeaderText = "Notes:";
            this.colNotes.Name = "colNotes";
            this.colNotes.Width = 200;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Location = new System.Drawing.Point(536, 49);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "&Add Item";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tblPracticeItems
            // 
            this.tblPracticeItems.AutoSize = true;
            this.tblPracticeItems.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblPracticeItems.ColumnCount = 4;
            this.tblPracticeItems.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131F));
            this.tblPracticeItems.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 273F));
            this.tblPracticeItems.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tblPracticeItems.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tblPracticeItems.Controls.Add(this.txtItem, 1, 1);
            this.tblPracticeItems.Controls.Add(this.cboArea, 0, 1);
            this.tblPracticeItems.Controls.Add(this.label1, 0, 0);
            this.tblPracticeItems.Controls.Add(this.label2, 1, 0);
            this.tblPracticeItems.Controls.Add(this.numMins, 2, 1);
            this.tblPracticeItems.Controls.Add(this.numSecs, 3, 1);
            this.tblPracticeItems.Controls.Add(this.label4, 3, 0);
            this.tblPracticeItems.Controls.Add(this.label3, 2, 0);
            this.tblPracticeItems.Location = new System.Drawing.Point(12, 27);
            this.tblPracticeItems.Name = "tblPracticeItems";
            this.tblPracticeItems.RowCount = 2;
            this.tblPracticeItems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.66667F));
            this.tblPracticeItems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.33333F));
            this.tblPracticeItems.Size = new System.Drawing.Size(518, 46);
            this.tblPracticeItems.TabIndex = 7;
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(134, 22);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(267, 20);
            this.txtItem.TabIndex = 1;
            // 
            // cboArea
            // 
            this.cboArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboArea.FormattingEnabled = true;
            this.cboArea.Location = new System.Drawing.Point(3, 22);
            this.cboArea.Name = "cboArea";
            this.cboArea.Size = new System.Drawing.Size(125, 21);
            this.cboArea.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Practice Area";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(134, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Practice Item";
            // 
            // numMins
            // 
            this.numMins.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.numMins.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.numMins.Location = new System.Drawing.Point(407, 22);
            this.numMins.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numMins.Name = "numMins";
            this.numMins.ReadOnly = true;
            this.numMins.Size = new System.Drawing.Size(51, 20);
            this.numMins.TabIndex = 9;
            // 
            // numSecs
            // 
            this.numSecs.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.numSecs.Increment = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numSecs.Location = new System.Drawing.Point(464, 22);
            this.numSecs.Maximum = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.numSecs.Name = "numSecs";
            this.numSecs.ReadOnly = true;
            this.numSecs.Size = new System.Drawing.Size(50, 20);
            this.numSecs.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(464, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Secs.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(407, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mins.";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 449);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.tblSchedule);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tblPracticeItems);
            this.Controls.Add(this.mnuMain);
            this.MainMenuStrip = this.mnuMain;
            this.Name = "frmMain";
            this.Text = "Practice Log";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblSchedule)).EndInit();
            this.tblPracticeItems.ResumeLayout(false);
            this.tblPracticeItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSecs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrCountDown;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.ToolStripMenuItem mnuSaveAs;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPracticeScheduleToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog savDialog;
        private System.Windows.Forms.OpenFileDialog opnDialog;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridView tblSchedule;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TableLayoutPanel tblPracticeItems;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.ComboBox cboArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numMins;
        private System.Windows.Forms.NumericUpDown numSecs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPracticeArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPracticeItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTimeMins;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSecs;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNotes;
    }
}

