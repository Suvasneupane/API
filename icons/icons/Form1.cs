using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ImageToIconConverter
{
    public partial class Form1 : Form
    {
        private Bitmap loadedImage;
        private byte[] iconBytes;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.bmp;*.gif";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    loadedImage = new Bitmap(ofd.FileName);
                    pictureBoxPreview.Image = loadedImage;
                    lblStatus.Text = "Status: Image loaded successfully.";
                    lblDimensions.Text = $"Image Dimensions: {loadedImage.Width}x{loadedImage.Height}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading image: " + ex.Message);
                lblStatus.Text = "Status: Error loading image.";
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (loadedImage == null)
            {
                MessageBox.Show("Please select an image first.");
                lblStatus.Text = "Status: No image selected.";
                return;
            }

            try
            {
                int[] sizes = { 16, 32, 48, 64, 128, 256 };
                using (MemoryStream ms = new MemoryStream())
                using (BinaryWriter bw = new BinaryWriter(ms))
                {
                    // ICO header
                    bw.Write((short)0);   // reserved
                    bw.Write((short)1);   // image type = icon
                    bw.Write((short)sizes.Length); // number of images

                    int offset = 6 + (16 * sizes.Length);

                    MemoryStream[] imageStreams = new MemoryStream[sizes.Length];

                    for (int i = 0; i < sizes.Length; i++)
                    {
                        Bitmap resized = new Bitmap(loadedImage, new Size(sizes[i], sizes[i]));
                        MemoryStream pngStream = new MemoryStream();
                        resized.Save(pngStream, System.Drawing.Imaging.ImageFormat.Png);
                        imageStreams[i] = pngStream;

                        bw.Write((byte)sizes[i]); // width
                        bw.Write((byte)sizes[i]); // height
                        bw.Write((byte)0); // colors
                        bw.Write((byte)0); // reserved
                        bw.Write((short)1); // planes
                        bw.Write((short)32); // bits per pixel
                        bw.Write((int)pngStream.Length); // size of image data
                        bw.Write(offset); // offset
                        offset += (int)pngStream.Length;
                    }

                    // Write image data
                    for (int i = 0; i < sizes.Length; i++)
                    {
                        bw.Write(imageStreams[i].ToArray());
                    }

                    iconBytes = ms.ToArray();
                }

                lblStatus.Text = "Status: Conversion successful. Ready to save.";
                MessageBox.Show("Image converted to ICO successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error converting image: " + ex.Message);
                lblStatus.Text = "Status: Conversion failed.";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (iconBytes == null)
            {
                MessageBox.Show("Please convert an image first.");
                lblStatus.Text = "Status: No ICO file to save.";
                return;
            }

            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Icon Files|*.ico";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(sfd.FileName, iconBytes);
                    lblStatus.Text = "Status: ICO file saved successfully.";
                    MessageBox.Show("ICO file saved successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving ICO: " + ex.Message);
                lblStatus.Text = "Status: Save failed.";
            }
        }

        // Drag-and-drop support
        private void pictureBoxPreview_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void pictureBoxPreview_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (files.Length > 0)
                {
                    string file = files[0];
                    string ext = Path.GetExtension(file).ToLower();
                    if (ext == ".png" || ext == ".jpg" || ext == ".jpeg" || ext == ".bmp" || ext == ".gif")
                    {
                        loadedImage = new Bitmap(file);
                        pictureBoxPreview.Image = loadedImage;
                        lblStatus.Text = "Status: Image loaded via drag-and-drop.";
                        lblDimensions.Text = $"Image Dimensions: {loadedImage.Width}x{loadedImage.Height}";
                    }
                    else
                    {
                        MessageBox.Show("Invalid file type. Please select an image.");
                        lblStatus.Text = "Status: Invalid file type.";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading image: " + ex.Message);
                lblStatus.Text = "Status: Error loading image.";
            }
        }
    }
}
