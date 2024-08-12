namespace printingPapersApp
{
    partial class selectFolder
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
            enterFileTextBox = new TextBox();
            searchForFilesButton = new Button();
            listView1 = new ListView();
            numberOfCopies = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            submitPrintsButton = new Button();
            selectFormBackButton = new Button();
            SuspendLayout();
            // 
            // enterFileTextBox
            // 
            enterFileTextBox.BackColor = SystemColors.Window;
            enterFileTextBox.ForeColor = Color.Gray;
            enterFileTextBox.Location = new Point(99, 75);
            enterFileTextBox.Name = "enterFileTextBox";
            enterFileTextBox.Size = new Size(240, 23);
            enterFileTextBox.TabIndex = 0;
            enterFileTextBox.Text = "Enter file name";
            enterFileTextBox.Enter += enterFileTextBox_Enter;
            enterFileTextBox.Leave += enterFileTextBox_Leave;
            // 
            // searchForFilesButton
            // 
            searchForFilesButton.Location = new Point(354, 74);
            searchForFilesButton.Name = "searchForFilesButton";
            searchForFilesButton.Size = new Size(75, 23);
            searchForFilesButton.TabIndex = 1;
            searchForFilesButton.Text = "Search";
            searchForFilesButton.UseVisualStyleBackColor = true;
            searchForFilesButton.Click += searchForFilesButton_Click;
            // 
            // listView1
            // 
            listView1.CheckBoxes = true;
            listView1.Columns.AddRange(new ColumnHeader[] { numberOfCopies, columnHeader1 });
            listView1.LabelEdit = true;
            listView1.Location = new Point(99, 117);
            listView1.Name = "listView1";
            listView1.Size = new Size(462, 125);
            listView1.TabIndex = 5;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // numberOfCopies
            // 
            numberOfCopies.DisplayIndex = 1;
            numberOfCopies.Text = "Number Of Copies";
            numberOfCopies.Width = 150;
            // 
            // columnHeader1
            // 
            columnHeader1.DisplayIndex = 0;
            columnHeader1.Text = "File Name";
            columnHeader1.Width = 300;
            // 
            // submitPrintsButton
            // 
            submitPrintsButton.Location = new Point(354, 286);
            submitPrintsButton.Name = "submitPrintsButton";
            submitPrintsButton.Size = new Size(118, 23);
            submitPrintsButton.TabIndex = 6;
            submitPrintsButton.Text = "Submit Prints";
            submitPrintsButton.UseVisualStyleBackColor = true;
            submitPrintsButton.Click += submitPrintsButton_Click;
            // 
            // selectFormBackButton
            // 
            selectFormBackButton.Location = new Point(713, 415);
            selectFormBackButton.Name = "selectFormBackButton";
            selectFormBackButton.Size = new Size(75, 23);
            selectFormBackButton.TabIndex = 7;
            selectFormBackButton.Text = "Back";
            selectFormBackButton.UseVisualStyleBackColor = true;
            selectFormBackButton.Click += selectFormBackButton_Click;
            // 
            // selectFolder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 79, 8);
            ClientSize = new Size(800, 450);
            Controls.Add(selectFormBackButton);
            Controls.Add(submitPrintsButton);
            Controls.Add(listView1);
            Controls.Add(searchForFilesButton);
            Controls.Add(enterFileTextBox);
            Name = "selectFolder";
            Text = "selectFolder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox enterFileTextBox;
        private Button searchForFilesButton;
        private ListView listView1;
        private ColumnHeader numberOfCopies;
        private ColumnHeader columnHeader1;
        private Button submitPrintsButton;
        private Button selectFormBackButton;
    }
}