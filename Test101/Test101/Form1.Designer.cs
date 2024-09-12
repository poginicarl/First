namespace Test101
{
    partial class Form1
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
            btnSave = new Button();
            btnReset = new Button();
            dgRecord = new DataGridView();
            txtFname = new TextBox();
            txtLname = new TextBox();
            cbDept = new ComboBox();
            lblFname = new Label();
            lblLname = new Label();
            label2 = new Label();
            openFileDialog1 = new OpenFileDialog();
            menuStrip1 = new MenuStrip();
            importToolStripMenuItem = new ToolStripMenuItem();
            excelFileToolStripMenuItem = new ToolStripMenuItem();
            textFileToolStripMenuItem = new ToolStripMenuItem();
            btnAddrecord = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)dgRecord).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(410, 354);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(97, 23);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save Record";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(522, 354);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(104, 23);
            btnReset.TabIndex = 1;
            btnReset.Text = "Reset Form";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // dgRecord
            // 
            dgRecord.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgRecord.Location = new Point(247, 34);
            dgRecord.Name = "dgRecord";
            dgRecord.Size = new Size(395, 301);
            dgRecord.TabIndex = 2;
            // 
            // txtFname
            // 
            txtFname.Location = new Point(25, 76);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(200, 23);
            txtFname.TabIndex = 3;
            // 
            // txtLname
            // 
            txtLname.Location = new Point(25, 141);
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(200, 23);
            txtLname.TabIndex = 4;
            // 
            // cbDept
            // 
            cbDept.FormattingEnabled = true;
            cbDept.Location = new Point(25, 205);
            cbDept.Name = "cbDept";
            cbDept.Size = new Size(200, 23);
            cbDept.TabIndex = 5;
            // 
            // lblFname
            // 
            lblFname.Location = new Point(25, 58);
            lblFname.Name = "lblFname";
            lblFname.Size = new Size(101, 15);
            lblFname.TabIndex = 6;
            lblFname.Text = "First Name";
            // 
            // lblLname
            // 
            lblLname.Location = new Point(25, 123);
            lblLname.Name = "lblLname";
            lblLname.Size = new Size(101, 15);
            lblLname.TabIndex = 7;
            lblLname.Text = "Last Name";
            // 
            // label2
            // 
            label2.Location = new Point(25, 187);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 8;
            label2.Text = "Department";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { importToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(654, 24);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // importToolStripMenuItem
            // 
            importToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { excelFileToolStripMenuItem, textFileToolStripMenuItem });
            importToolStripMenuItem.Name = "importToolStripMenuItem";
            importToolStripMenuItem.Size = new Size(55, 20);
            importToolStripMenuItem.Text = "Import";
            // 
            // excelFileToolStripMenuItem
            // 
            excelFileToolStripMenuItem.Name = "excelFileToolStripMenuItem";
            excelFileToolStripMenuItem.Size = new Size(180, 22);
            excelFileToolStripMenuItem.Text = "Excel File";
            excelFileToolStripMenuItem.Click += excelFileToolStripMenuItem_Click;
            // 
            // textFileToolStripMenuItem
            // 
            textFileToolStripMenuItem.Name = "textFileToolStripMenuItem";
            textFileToolStripMenuItem.Size = new Size(180, 22);
            textFileToolStripMenuItem.Text = "Text File";
            textFileToolStripMenuItem.Click += textFileToolStripMenuItem_Click;
            // 
            // btnAddrecord
            // 
            btnAddrecord.Location = new Point(38, 255);
            btnAddrecord.Name = "btnAddrecord";
            btnAddrecord.Size = new Size(88, 23);
            btnAddrecord.TabIndex = 10;
            btnAddrecord.Text = "Add Record";
            btnAddrecord.UseVisualStyleBackColor = true;
            btnAddrecord.Click += btnAddrecord_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(136, 255);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(654, 413);
            Controls.Add(btnCancel);
            Controls.Add(btnAddrecord);
            Controls.Add(label2);
            Controls.Add(lblLname);
            Controls.Add(lblFname);
            Controls.Add(cbDept);
            Controls.Add(txtLname);
            Controls.Add(txtFname);
            Controls.Add(dgRecord);
            Controls.Add(btnReset);
            Controls.Add(btnSave);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgRecord).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Button btnReset;
        private DataGridView dgRecord;
        private TextBox txtFname;
        private TextBox txtLname;
        private ComboBox cbDept;
        private Label lblFname;
        private Label lblLname;
        private Label label2;
        private OpenFileDialog openFileDialog1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem importToolStripMenuItem;
        private ToolStripMenuItem excelFileToolStripMenuItem;
        private ToolStripMenuItem textFileToolStripMenuItem;
        private Button btnAddrecord;
        private Button btnCancel;
    }
}
