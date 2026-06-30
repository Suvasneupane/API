namespace OfficeToPDFConverter
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btnSelectWord = new System.Windows.Forms.Button();
            this.btnSelectPowerPoint = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnSelectOutput = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.txtOutputPath = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.listBoxFiles = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnSelectWord
            // 
            this.btnSelectWord.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            this.btnSelectWord.ForeColor = System.Drawing.Color.White;
            this.btnSelectWord.Location = new System.Drawing.Point(30, 30);
            this.btnSelectWord.Name = "btnSelectWord";
            this.btnSelectWord.Size = new System.Drawing.Size(150, 40);
            this.btnSelectWord.TabIndex = 0;
            this.btnSelectWord.Text = "Select Word File";
            this.btnSelectWord.UseVisualStyleBackColor = false;
            this.btnSelectWord.Click += new System.EventHandler(this.btnSelectWord_Click);
            // 
            // btnSelectPowerPoint
            // 
            this.btnSelectPowerPoint.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            this.btnSelectPowerPoint.ForeColor = System.Drawing.Color.White;
            this.btnSelectPowerPoint.Location = new System.Drawing.Point(200, 30);
            this.btnSelectPowerPoint.Name = "btnSelectPowerPoint";
            this.btnSelectPowerPoint.Size = new System.Drawing.Size(180, 40);
            this.btnSelectPowerPoint.TabIndex = 1;
            this.btnSelectPowerPoint.Text = "Select PowerPoint File";
            this.btnSelectPowerPoint.UseVisualStyleBackColor = false;
            this.btnSelectPowerPoint.Click += new System.EventHandler(this.btnSelectPowerPoint_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.Color.FromArgb(28, 151, 234);
            this.btnConvert.ForeColor = System.Drawing.Color.White;
            this.btnConvert.Location = new System.Drawing.Point(400, 30);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(150, 40);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "Convert to PDF";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnSelectOutput
            // 
            this.btnSelectOutput.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            this.btnSelectOutput.ForeColor = System.Drawing.Color.White;
            this.btnSelectOutput.Location = new System.Drawing.Point(30, 90);
            this.btnSelectOutput.Name = "btnSelectOutput";
            this.btnSelectOutput.Size = new System.Drawing.Size(150, 40);
            this.btnSelectOutput.TabIndex = 3;
            this.btnSelectOutput.Text = "Select Output Folder";
            this.btnSelectOutput.UseVisualStyleBackColor = false;
            this.btnSelectOutput.Click += new System.EventHandler(this.btnSelectOutput_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.txtFilePath.ForeColor = System.Drawing.Color.White;
            this.txtFilePath.Location = new System.Drawing.Point(200, 100);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(350, 22);
            this.txtFilePath.TabIndex = 4;
            // 
            // txtOutputPath
            // 
            this.txtOutputPath.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.txtOutputPath.ForeColor = System.Drawing.Color.White;
            this.txtOutputPath.Location = new System.Drawing.Point(200, 140);
            this.txtOutputPath.Name = "txtOutputPath";
            this.txtOutputPath.Size = new System.Drawing.Size(350, 22);
            this.txtOutputPath.TabIndex = 5;
            // 
            // lblStatus
            // 
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(30, 180);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(520, 23);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Ready";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(30, 210);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(520, 20);
            this.progressBar.TabIndex = 7;
            // 
            // listBoxFiles
            // 
            this.listBoxFiles.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.listBoxFiles.ForeColor = System.Drawing.Color.White;
            this.listBoxFiles.FormattingEnabled = true;
            this.listBoxFiles.ItemHeight = 16;
            this.listBoxFiles.Location = new System.Drawing.Point(30, 250);
            this.listBoxFiles.Name = "listBoxFiles";
            this.listBoxFiles.Size = new System.Drawing.Size(520, 100);
            this.listBoxFiles.TabIndex = 8;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.ClientSize = new System.Drawing.Size(600, 380);
            this.Controls.Add(this.listBoxFiles);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtOutputPath);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btnSelectOutput);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnSelectPowerPoint);
            this.Controls.Add(this.btnSelectWord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Office To PDF Converter";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnSelectWord;
        private System.Windows.Forms.Button btnSelectPowerPoint;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnSelectOutput;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.TextBox txtOutputPath;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ListBox listBoxFiles;
    }
}
