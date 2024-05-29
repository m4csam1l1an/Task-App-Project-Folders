namespace Task_App
{
    partial class TaskApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            dgTaskList = new DataGridView();
            TaskView = new DataGridViewTextBoxColumn();
            Priority = new DataGridViewTextBoxColumn();
            Finishing_Date = new DataGridViewTextBoxColumn();
            lbTaskDescription = new Label();
            txtTaskDescription = new TextBox();
            lbPriority = new Label();
            lbFinishingDate = new Label();
            cbPriority = new ComboBox();
            dtFinishingDate = new DateTimePicker();
            btnAdd = new Button();
            btnClearFields = new Button();
            btnQuit = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnSaveAs = new Button();
            btnSearchTask = new Button();
            ((System.ComponentModel.ISupportInitialize)dgTaskList).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(32, 32);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // dgTaskList
            // 
            dgTaskList.AllowUserToOrderColumns = true;
            dgTaskList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgTaskList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgTaskList.BackgroundColor = SystemColors.ActiveCaption;
            dgTaskList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgTaskList.Columns.AddRange(new DataGridViewColumn[] { TaskView, Priority, Finishing_Date });
            dgTaskList.Dock = DockStyle.Bottom;
            dgTaskList.Location = new Point(0, 173);
            dgTaskList.Margin = new Padding(2, 1, 2, 1);
            dgTaskList.Name = "dgTaskList";
            dgTaskList.RowHeadersWidth = 82;
            dgTaskList.Size = new Size(635, 211);
            dgTaskList.TabIndex = 1;
            dgTaskList.UseWaitCursor = true;
            // 
            // TaskView
            // 
            TaskView.HeaderText = "Task";
            TaskView.MinimumWidth = 10;
            TaskView.Name = "TaskView";
            // 
            // Priority
            // 
            Priority.HeaderText = "Priority";
            Priority.MinimumWidth = 10;
            Priority.Name = "Priority";
            // 
            // Finishing_Date
            // 
            Finishing_Date.HeaderText = "Finishing_Date";
            Finishing_Date.MinimumWidth = 10;
            Finishing_Date.Name = "Finishing_Date";
            // 
            // lbTaskDescription
            // 
            lbTaskDescription.AutoSize = true;
            lbTaskDescription.Location = new Point(6, 19);
            lbTaskDescription.Margin = new Padding(2, 0, 2, 0);
            lbTaskDescription.Name = "lbTaskDescription";
            lbTaskDescription.Size = new Size(95, 15);
            lbTaskDescription.TabIndex = 2;
            lbTaskDescription.Text = "Task Description:";
            // 
            // txtTaskDescription
            // 
            txtTaskDescription.Location = new Point(113, 16);
            txtTaskDescription.Margin = new Padding(2, 1, 2, 1);
            txtTaskDescription.Name = "txtTaskDescription";
            txtTaskDescription.Size = new Size(325, 23);
            txtTaskDescription.TabIndex = 3;
            // 
            // lbPriority
            // 
            lbPriority.AutoSize = true;
            lbPriority.Location = new Point(6, 59);
            lbPriority.Margin = new Padding(2, 0, 2, 0);
            lbPriority.Name = "lbPriority";
            lbPriority.Size = new Size(48, 15);
            lbPriority.TabIndex = 4;
            lbPriority.Text = "Priority:";
            // 
            // lbFinishingDate
            // 
            lbFinishingDate.AutoSize = true;
            lbFinishingDate.Location = new Point(6, 100);
            lbFinishingDate.Margin = new Padding(2, 0, 2, 0);
            lbFinishingDate.Name = "lbFinishingDate";
            lbFinishingDate.Size = new Size(85, 15);
            lbFinishingDate.TabIndex = 5;
            lbFinishingDate.Text = "Finishing Date:";
            // 
            // cbPriority
            // 
            cbPriority.FormattingEnabled = true;
            cbPriority.Items.AddRange(new object[] { "urgent and important, ", "important but not urgent, ", "urgent but not important, ", "neither urgent nor important." });
            cbPriority.Location = new Point(113, 56);
            cbPriority.Margin = new Padding(2, 1, 2, 1);
            cbPriority.Name = "cbPriority";
            cbPriority.Size = new Size(233, 23);
            cbPriority.TabIndex = 6;
            // 
            // dtFinishingDate
            // 
            dtFinishingDate.Location = new Point(113, 94);
            dtFinishingDate.Margin = new Padding(2, 1, 2, 1);
            dtFinishingDate.Name = "dtFinishingDate";
            dtFinishingDate.Size = new Size(217, 23);
            dtFinishingDate.TabIndex = 7;
            dtFinishingDate.Value = new DateTime(2024, 5, 10, 15, 12, 2, 0);
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(192, 255, 192);
            btnAdd.ForeColor = SystemColors.ControlText;
            btnAdd.Location = new Point(6, 131);
            btnAdd.Margin = new Padding(2, 1, 2, 1);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(115, 26);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add Task";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClearFields
            // 
            btnClearFields.BackColor = Color.FromArgb(255, 192, 192);
            btnClearFields.ForeColor = SystemColors.ControlText;
            btnClearFields.Location = new Point(510, 12);
            btnClearFields.Name = "btnClearFields";
            btnClearFields.Size = new Size(116, 29);
            btnClearFields.TabIndex = 9;
            btnClearFields.Text = "Clear Fields";
            btnClearFields.UseVisualStyleBackColor = false;
            btnClearFields.Click += btnclear_Click;
            // 
            // btnQuit
            // 
            btnQuit.BackColor = Color.FromArgb(255, 192, 192);
            btnQuit.Location = new Point(510, 93);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(116, 29);
            btnQuit.TabIndex = 10;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = false;
            btnQuit.Click += btnQuit_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(192, 255, 192);
            btnUpdate.Location = new Point(127, 131);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 26);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 192, 192);
            btnDelete.Location = new Point(510, 52);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(116, 29);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // btnSaveAs
            // 
            btnSaveAs.BackColor = Color.FromArgb(192, 255, 192);
            btnSaveAs.Location = new Point(247, 131);
            btnSaveAs.Name = "btnSaveAs";
            btnSaveAs.Size = new Size(117, 27);
            btnSaveAs.TabIndex = 13;
            btnSaveAs.Text = "Save As";
            btnSaveAs.UseVisualStyleBackColor = false;
            btnSaveAs.Click += btnSaveAs_Click_1;
            // 
            // btnSearchTask
            // 
            btnSearchTask.BackColor = Color.FromArgb(192, 255, 192);
            btnSearchTask.ForeColor = SystemColors.ControlText;
            btnSearchTask.Location = new Point(369, 131);
            btnSearchTask.Margin = new Padding(2, 1, 2, 1);
            btnSearchTask.Name = "btnSearchTask";
            btnSearchTask.Size = new Size(115, 26);
            btnSearchTask.TabIndex = 14;
            btnSearchTask.Text = "Search Task";
            btnSearchTask.UseVisualStyleBackColor = false;
            btnSearchTask.Click += btnSearchTask_Click;
            // 
            // TaskApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 384);
            Controls.Add(btnSearchTask);
            Controls.Add(btnSaveAs);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnQuit);
            Controls.Add(btnClearFields);
            Controls.Add(btnAdd);
            Controls.Add(dtFinishingDate);
            Controls.Add(cbPriority);
            Controls.Add(lbFinishingDate);
            Controls.Add(lbPriority);
            Controls.Add(txtTaskDescription);
            Controls.Add(lbTaskDescription);
            Controls.Add(dgTaskList);
            Margin = new Padding(2, 1, 2, 1);
            Name = "TaskApp";
            Text = "Task Manager";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgTaskList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private DataGridView dgTaskList;
        private DataGridViewTextBoxColumn TaskView;
        private DataGridViewTextBoxColumn Priority;
        private DataGridViewTextBoxColumn Finishing_Date;
        private Label lbTaskDescription;
        private TextBox txtTaskDescription;
        private Label lbPriority;
        private Label lbFinishingDate;
        private ComboBox cbPriority;
        private DateTimePicker dtFinishingDate;
        private Button btnAdd;
        private Button btnClearFields;
        private Button btnQuit;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnSaveAs;
        private Button btnSearchTask;
    }
}
