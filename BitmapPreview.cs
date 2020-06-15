using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Chain_of_Responsibility
{
    public class BitmapPreview : Previewer
    {
        public override void HandleFileType(OpenFileDialog ofd, Form form)
        {
            string extension = Path.GetExtension(ofd.SafeFileName);
            if (extension == ".bmp")
                CreatePictureBox(ofd, form);
            else if (NextPreviewer != null)
                NextPreviewer.HandleFileType(ofd, form);
        }
        PictureBox pictureBox;
        private void CreatePictureBox(OpenFileDialog ofd, Form form)
        {
            pictureBox = new PictureBox();
            pictureBox.Location = new System.Drawing.Point(12, 54);
            pictureBox.Size = new System.Drawing.Size(617, 330);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            string image = ofd.FileName;
            Bitmap bimage = new Bitmap(image);
            form.Controls.Add(pictureBox);
            pictureBox.Image = bimage;
        }
    }
}
