using System;
using System.Windows.Forms;

namespace Chain_of_Responsibility
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }
        OpenFileDialog ofd = new OpenFileDialog();
        private void openButton_Click(object sender, EventArgs e)
        {
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                Previewer textPreviewer, bitmapPreviewer, binaryPreviewer;
                textPreviewer = new TextPreview();
                bitmapPreviewer = new BitmapPreview();
                binaryPreviewer = new BinaryPreview();
                textPreviewer.SetNextPreviewer(bitmapPreviewer);
                bitmapPreviewer.SetNextPreviewer(binaryPreviewer);
                textPreviewer.HandleFileType(ofd, this);
            }

        }
    }
}
