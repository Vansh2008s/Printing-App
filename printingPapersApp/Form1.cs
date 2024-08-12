using PdfiumViewer;
using System.Drawing.Printing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System;

namespace printingPapersApp
{
    public partial class Form1 : Form
    {
        List<Files> files = new List<Files>();
        List<string> fileNames = new List<string>();
        PrinterSettings settings = new PrinterSettings();
        List<newPrint> currentPrintJobs = new List<newPrint>();

        bool hasDelay = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadFiles()
        {
            files = SqliteDatAccess.LoadFiles();
            //displayFileNames();
        }

        private void LoadFileName()
        {
            LoadFiles();
            fileNames.Clear();
            foreach (Files f in files)
            {
                fileNames.Add(f.FileName);
            }
        }
        private void displayFileNames()
        {
            string totalNames = "";
            foreach (var file in files)
            {
                string temp = file.FileName;
                totalNames += temp + ", ";
            }
            MessageBox.Show(totalNames);
        }

        private void insertFile(Files f)
        {
            bool isRepeatFile;
            isRepeatFile = checkRepeatFiles(f);
            if (!isRepeatFile)
            {
                SqliteDatAccess.insertFile(f);
            }

            LoadFiles();
        }

        private bool checkRepeatFiles(Files f)
        {
            LoadFiles();
            LoadFileName();
            if (fileNames.Contains(f.FileName))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void addFileButton_Click(object sender, EventArgs e)
        {
            addFiles();
        }

        private void addFiles()
        {
            LoadFiles();
            int currentID;
            if (files.Count > 0)
            {
                currentID = files[files.Count - 1].id;
            }
            else
            {
                currentID = 0;
            }
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Files f = new Files();
                f.id = currentID + 1;
                f.FileName = openFileDialog1.FileName;
                f.FileCount = 0;
                insertFile(f);
            }
        }

        async private void printPacket()
        {
            if (currentPrintJobs.Count > 0)
            {
                string path = currentPrintJobs[0].fileName;
                int numOfCopies = currentPrintJobs[0].numberOfCopies;
                using (var document = PdfDocument.Load(path))
                {
                    using (var printDocument = document.CreatePrintDocument())
                    {
                        printDocument.PrinterSettings.PrintFileName = path;
                        printDocument.PrinterSettings.PrinterName = settings.PrinterName;
                        printDocument.DocumentName = Path.GetFileName(path);
                        printDocument.PrinterSettings.PrintFileName = Path.GetFileName(path);
                        printDocument.PrinterSettings.Copies = 0;
                        printDocument.PrintController = new StandardPrintController();
                        printDocument.Print();
                    }
                }
                AddPrintSqlite.deletePrintJob(path);
                currentPrintJobs = AddPrintSqlite.LoadFiles();
                listView1.Items[0].SubItems[2].Text = "Yes";
                if (hasDelay)
                {
                    int delayNumber = (int ) addDelayEntry.Value;
                    await Task.Delay(numOfCopies * delayNumber * 1000);
                }
                startPrints();

            }
            else
            {
                MessageBox.Show("All prints have been sent!");
            }

        }

        async private void startPrints() // Add a timer
        {
            updatePrintJobs();
            printPacket();
        }

        private void updatePrintJobs()
        {

            currentPrintJobs = AddPrintSqlite.LoadFiles();
            listView1.Items.Clear();
            foreach (newPrint print in currentPrintJobs)
            {
                ListViewItem item = new ListViewItem(Path.GetFileName(print.fileName));
                item.SubItems.Add(print.numberOfCopies.ToString());
                item.SubItems.Add("No");
                listView1.Items.Add(item);
            }
        }

        private void addFolderFiles(string folderPath)
        {
            LoadFiles();
            int currentID;
            if (files.Count > 0)
            {
                currentID = files[files.Count - 1].id;
            }
            else
            {
                currentID = 0;
            }
            string[] folderFiles = Directory.GetFiles(folderPath);
            foreach (string file in folderFiles)
            {
                if (Path.GetExtension(file) == ".pdf")
                {
                    currentID++;
                    Files f = new Files();
                    f.id = currentID;
                    f.FileName = file;
                    f.FileCount = 0;
                    insertFile(f);
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadFiles();
            updatePrintJobs();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            startPrints();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqliteDatAccess.deleteAll();
        }

        private void selectFileButton_Click(object sender, EventArgs e)
        {
            selectFolder selectFolder = new selectFolder();
            selectFolder.Show();
            this.Hide();
        }

        private void addFolderButton_Click(object sender, EventArgs e)
        {
            string folderPath = "";
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                folderPath = folderBrowserDialog1.SelectedPath;
            }
            addFolderFiles(folderPath);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            hasDelay = !hasDelay;
        }

        /*private double SendToPrinter()
        {
            string path = "";
            if (files.Count == 0)
            {
                MessageBox.Show("Add files first!");
                return 0;
            } else
            {
                path = files[0].FileName;
            }
            
            int ignoreMe;
            var numberOfFiles = Interaction.InputBox("Enter how many copies to print", "Number of copies", "1", 200, 200);
            int printNumber = 1;
            while (true)
            {
                if (int.TryParse(numberOfFiles, out ignoreMe))
                {
                    printNumber = int.Parse(numberOfFiles);
                    break;
                }
                else
                {
                    numberOfFiles = Interaction.InputBox("Please only enter an integer amount of copies", "Number of copies", "1", 200, 200);
                }
            }
            
            using (var document = PdfDocument.Load(path))
            {
                using (var printDocument = document.CreatePrintDocument())
                {
                    printDocument.PrinterSettings.PrintFileName = files[0].FileName;
                    printDocument.PrinterSettings.PrinterName = settings.PrinterName;
                    printDocument.DocumentName = "file.pdf";
                    printDocument.PrinterSettings.PrintFileName = "file.pdf";
                    printDocument.PrinterSettings.Copies = (short) printNumber;
                    printDocument.PrintController = new StandardPrintController();     
                }
            }
            return 0;
        }*/

    }
}
