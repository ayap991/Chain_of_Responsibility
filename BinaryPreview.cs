using System.Windows.Forms;
using System.ComponentModel.Design;

namespace Chain_of_Responsibility
{
    public class BinaryPreview : Previewer
    {
        public override void HandleFileType(OpenFileDialog ofd, Form form)
        {
            CreateByteViewer(ofd, form);
        }
        ByteViewer byteViewer;
        Panel panel;
        private void CreateByteViewer(OpenFileDialog ofd, Form form)
        {
            panel = new Panel();
            byteViewer = new ByteViewer();
            byteViewer.Dock = DockStyle.Fill;
            byteViewer.SetBytes(new byte[] { });
            byteViewer.SetFile(ofd.FileName);
            panel.Location = new System.Drawing.Point(12, 54);
            panel.Name = "panel";
            panel.Size = new System.Drawing.Size(617, 330);
            panel.TabIndex = 2;
            form.Controls.Add(panel);
            panel.Controls.Add(byteViewer);
        }
    }
}
