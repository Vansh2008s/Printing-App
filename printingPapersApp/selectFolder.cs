using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace printingPapersApp
{
    public partial class selectFolder : Form
    {
        List<Files> files = new List<Files>();
        List<string> matchingFileNames = new List<string>();
        string enteredName = "";
        public selectFolder()
        {
            InitializeComponent();
        }

        private void LoadFiles()
        {
            files = SqliteDatAccess.LoadFiles();
            //displayFileNames();
        }

        private void searchForFiles()
        {
            listView1.Items.Clear();
            foreach (var file in files)
            {
                if (file.FileName.Contains(enteredName))
                {
                    matchingFileNames.Add(Path.GetFileName(file.FileName));
                }
            }
        }

        private void enterFileTextBox_Enter(object sender, EventArgs e)
        {
            if (enterFileTextBox.Text.Equals("Enter file name"))
            {
                enterFileTextBox.Text = "";
                enterFileTextBox.ForeColor = Color.Black;
            }
        }

        private void enterFileTextBox_Leave(object sender, EventArgs e)
        {
            if (enterFileTextBox.Text.Equals(""))
            {
                enterFileTextBox.Text = "Enter file name";
                enterFileTextBox.ForeColor = Color.Gray;
            }

        }

        private void searchForFilesButton_Click(object sender, EventArgs e)
        {
            enteredName = enterFileTextBox.Text;

            LoadFiles();
            searchForFiles();
            foreach (var name in matchingFileNames)
            {

                ListViewItem item = new ListViewItem("0");
                item.SubItems.Add(name);
                listView1.Items.Add(item);
            }
            matchingFileNames.Clear();
            MessageBox.Show("Searching");
            //addTextBoxes();
        }

        private void submitPrintsButton_Click(object sender, EventArgs e)
        {

            foreach (ListViewItem item in listView1.CheckedItems)
            {
                string fileName = item.SubItems[1].Text;
                int copyNumber = 0;
                bool isValid = false;
                while (true)
                {
                    int ignoreMeTemp = 0;
                    if (int.TryParse(item.Text, out ignoreMeTemp))
                    {
                        if (ignoreMeTemp > 0)
                        {
                            copyNumber = int.Parse(item.Text);
                            isValid = true;
                            break;
                        }
                        else
                        {
                            MessageBox.Show("Please make sure all selected files have more than 0 copies");
                            break;
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Make sure to only have numbers in the number of copies column!");
                        break;
                    }
                }
                if(isValid)
                {
                    newPrint newPrint = new newPrint();
                    newPrint.fileName = findFilePath(fileName); // Not working in finding path, only "" is being returned
                    newPrint.numberOfCopies = copyNumber;
                    AddPrintSqlite.insertPrint(newPrint);
                }
                
            }

        }


        private string findFilePath(string fileName) // Check this method for problem
        {
            foreach (Files f in files)
            {
                if (f.FileName.Contains(fileName)) return f.FileName;
            }
            return "";
        }

        private void selectFormBackButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
        
    }
}
