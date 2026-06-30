using System;
using System.IO;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using PowerPoint = Microsoft.Office.Interop.PowerPoint;



namespace OfficeToPDFConverter
{
    public partial class Form1 : Form
    {
        private string selectedFilePath = string.Empty;
        private string outputFolderPath = string.Empty;

        public Form1()
        {
            InitializeComponent();
            AllowDrop = true;
            DragEnter += Form1_DragEnter;
            DragDrop += Form1_DragDrop;
            btnConvert.Enabled = false;
        }

        private void btnSelectWord_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Word Documents (*.docx)|*.docx"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                selectedFilePath = ofd.FileName;
                txtFilePath.Text = selectedFilePath;
                listBoxFiles.Items.Add(Path.GetFileName(selectedFilePath));
                ValidateFile();
            }
        }

        private void btnSelectPowerPoint_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "PowerPoint Presentations (*.pptx)|*.pptx"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                selectedFilePath = ofd.FileName;
                txtFilePath.Text = selectedFilePath;
                listBoxFiles.Items.Add(Path.GetFileName(selectedFilePath));
                ValidateFile();
            }
        }

        private void btnSelectOutput_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                outputFolderPath = fbd.SelectedPath;
                txtOutputPath.Text = outputFolderPath;
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(selectedFilePath) || string.IsNullOrEmpty(outputFolderPath))
                {
                    MessageBox.Show("Please select a file and output folder.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string ext = Path.GetExtension(selectedFilePath).ToLower();
                string outputFile = Path.Combine(outputFolderPath, Path.GetFileNameWithoutExtension(selectedFilePath) + ".pdf");

                lblStatus.Text = "Converting...";
                progressBar.Value = 50;

                if (ext == ".docx")
                {
                    ConvertWordToPdf(selectedFilePath, outputFile);
                }
                else if (ext == ".pptx")
                {
                    ConvertPowerPointToPdf(selectedFilePath, outputFile);
                }
                else
                {
                    MessageBox.Show("Unsupported file type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                progressBar.Value = 100;
                lblStatus.Text = "Success!";
                MessageBox.Show("Conversion completed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Error";
                MessageBox.Show("Conversion failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConvertWordToPdf(string inputFile, string outputFile)
        {
            Word.Application wordApp = new Word.Application();
            Word.Document doc = null;
            try
            {
                doc = wordApp.Documents.Open(inputFile);
                doc.ExportAsFixedFormat(outputFile, Word.WdExportFormat.wdExportFormatPDF);
            }
            finally
            {
                if (doc != null)
                {
                    doc.Close(false);
                }
                wordApp.Quit();
            }
        }

        private void ConvertPowerPointToPdf(string inputFile, string outputFile)
        {
            PowerPoint.Application pptApp = new PowerPoint.Application();
            PowerPoint.Presentation presentation = null;
            try
            {
                presentation = pptApp.Presentations.Open(inputFile,
                    PowerPoint.MsoTriState.msoTrue,
                    PowerPoint.MsoTriState.msoFalse,
                    PowerPoint.MsoTriState.msoFalse);

                presentation.SaveAs(outputFile, PowerPoint.PpSaveAsFileType.ppSaveAsPDF, PowerPoint.MsoTriState.msoTrue);
            }
            finally
            {
                if (presentation != null)
                {
                    presentation.Close();
                }
                pptApp.Quit();
            }
        }

        private void ValidateFile()
        {
            if (!string.IsNullOrEmpty(selectedFilePath) &&
                (selectedFilePath.EndsWith(".docx") || selectedFilePath.EndsWith(".pptx")))
            {
                btnConvert.Enabled = true;
            }
            else
            {
                btnConvert.Enabled = false;
            }
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length > 0)
            {
                selectedFilePath = files[0];
                txtFilePath.Text = selectedFilePath;
                listBoxFiles.Items.Add(Path.GetFileName(selectedFilePath));
                ValidateFile();
            }
        }
    }
}
