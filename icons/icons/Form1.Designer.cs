namespace ImageToIconConverter
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox pictureBoxPreview;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblDimensions;
        private System.Windows.Forms.Label lblIconSizes;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblDimensions = new System.Windows.Forms.Label();
            this.lblIconSizes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPreview
            // 
            this.pictureBoxPreview.BackColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.pictureBoxPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPreview.Location = new System.Drawing.Point(20, 20);
            this.pictureBoxPreview.Name = "pictureBoxPreview";
            this.pictureBoxPreview.Size = new System.Drawing.Size(256, 256);
            this.pictureBoxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPreview.TabIndex = 0;
            this.pictureBoxPreview.TabStop = false;
            this.pictureBoxPreview.AllowDrop = true;
            this.pictureBoxPreview.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBoxPreview_DragEnter);
            this.pictureBoxPreview.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBoxPreview_DragDrop);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(300, 40);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(120, 40);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse Image";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            this.toolTip1.SetToolTip(this.btnBrowse, "Select an image file");
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(300, 100);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(120, 40);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "Convert To ICO";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            this.toolTip1.SetToolTip(this.btnConvert, "Convert the selected image to ICO format");
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(300, 160);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 40);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save ICO";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.toolTip1.SetToolTip(this.btnSave, "Save the generated ICO file");
            // 
            // lblStatus
            // 
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(20, 290);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(400, 23);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Status: Waiting for image...";
            // 
            // lblDimensions
            // 
            this.lblDimensions.ForeColor = System.Drawing.Color.White;
            this.lblDimensions.Location = new System.Drawing.Point(20, 320);
            this.lblDimensions.Name = "lblDimensions";
            this.lblDimensions.Size = new System.Drawing.Size(400, 23);
            this.lblDimensions.TabIndex = 5;
            this.lblDimensions.Text = "Image Dimensions: -";
            // 
            // lblIconSizes
            // 
            this.lblIconSizes.ForeColor = System.Drawing.Color.White;
            this.lblIconSizes.Location = new System.Drawing.Point(20, 350);
            this.lblIconSizes.Name = "lblIconSizes";
            this.lblIconSizes.Size = new System.Drawing.Size(400, 23);
            this.lblIconSizes.TabIndex = 6;
            this.lblIconSizes.Text = "Icon Sizes: 16, 32, 48, 64, 128, 256";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.ClientSize = new System.Drawing.Size(450, 400);
            this.Controls.Add(this.lblIconSizes);
            this.Controls.Add(this.lblDimensions);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.pictureBoxPreview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Image To Icon Converter";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
