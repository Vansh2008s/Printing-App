namespace printingPapersApp
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
            addFileButton = new Button();
            printButton = new Button();
            openFileDialog1 = new OpenFileDialog();
            button1 = new Button();
            selectFileButton = new Button();
            listView1 = new ListView();
            currentPrints = new ColumnHeader();
            copyNumber = new ColumnHeader();
            finishedPrint = new ColumnHeader();
            printingJobsLabel = new Label();
            addFolderButton = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            checkBox1 = new CheckBox();
            addDelayEntry = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)addDelayEntry).BeginInit();
            SuspendLayout();
            // 
            // addFileButton
            // 
            addFileButton.Location = new Point(85, 105);
            addFileButton.Name = "addFileButton";
            addFileButton.Size = new Size(75, 23);
            addFileButton.TabIndex = 0;
            addFileButton.Text = "Add 1 File";
            addFileButton.UseVisualStyleBackColor = true;
            addFileButton.Click += addFileButton_Click;
            // 
            // printButton
            // 
            printButton.Location = new Point(85, 297);
            printButton.Name = "printButton";
            printButton.Size = new Size(75, 23);
            printButton.TabIndex = 1;
            printButton.Text = "Print";
            printButton.UseVisualStyleBackColor = true;
            printButton.Click += printButton_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            button1.Location = new Point(577, 374);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "DELETE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // selectFileButton
            // 
            selectFileButton.Location = new Point(86, 134);
            selectFileButton.Name = "selectFileButton";
            selectFileButton.Size = new Size(75, 23);
            selectFileButton.TabIndex = 3;
            selectFileButton.Text = "Select File";
            selectFileButton.UseVisualStyleBackColor = true;
            selectFileButton.Click += selectFileButton_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { currentPrints, copyNumber, finishedPrint });
            listView1.Location = new Point(269, 76);
            listView1.Name = "listView1";
            listView1.Size = new Size(420, 208);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // currentPrints
            // 
            currentPrints.Text = "Prints";
            currentPrints.Width = 250;
            // 
            // copyNumber
            // 
            copyNumber.Text = "Copies";
            // 
            // finishedPrint
            // 
            finishedPrint.Text = "In Progress?";
            finishedPrint.Width = 100;
            // 
            // printingJobsLabel
            // 
            printingJobsLabel.AutoSize = true;
            printingJobsLabel.Font = new Font("Tempus Sans ITC", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            printingJobsLabel.Location = new Point(416, 49);
            printingJobsLabel.Name = "printingJobsLabel";
            printingJobsLabel.Size = new Size(144, 24);
            printingJobsLabel.TabIndex = 5;
            printingJobsLabel.Text = "PRINTING JOBS";
            // 
            // addFolderButton
            // 
            addFolderButton.Location = new Point(85, 76);
            addFolderButton.Name = "addFolderButton";
            addFolderButton.Size = new Size(75, 23);
            addFolderButton.TabIndex = 6;
            addFolderButton.Text = "Add Folder";
            addFolderButton.UseVisualStyleBackColor = true;
            addFolderButton.Click += addFolderButton_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(85, 216);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(82, 19);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Add Delay";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // addDelayEntry
            // 
            addDelayEntry.Location = new Point(85, 241);
            addDelayEntry.Name = "addDelayEntry";
            addDelayEntry.Size = new Size(76, 23);
            addDelayEntry.TabIndex = 9;
            addDelayEntry.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 79, 8);
            ClientSize = new Size(738, 450);
            Controls.Add(addDelayEntry);
            Controls.Add(checkBox1);
            Controls.Add(addFolderButton);
            Controls.Add(printingJobsLabel);
            Controls.Add(listView1);
            Controls.Add(selectFileButton);
            Controls.Add(button1);
            Controls.Add(printButton);
            Controls.Add(addFileButton);
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)addDelayEntry).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addFileButton;
        private Button printButton;
        private OpenFileDialog openFileDialog1;
        private Button button1;
        private Button selectFileButton;
        private ListView listView1;
        private ColumnHeader currentPrints;
        private Label printingJobsLabel;
        private ColumnHeader copyNumber;
        private ColumnHeader finishedPrint;
        private Button addFolderButton;
        private FolderBrowserDialog folderBrowserDialog1;
        private CheckBox checkBox1;
        private TextBox delayEntryTextBox;
        private NumericUpDown addDelayEntry;
    }
}
