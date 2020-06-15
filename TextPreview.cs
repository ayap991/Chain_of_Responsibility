using System.IO;
using System.Windows.Forms;

namespace Chain_of_Responsibility
{
    public class TextPreview : Previewer
    {
        public override void HandleFileType(OpenFileDialog ofd, Form form)
        {
            string extension = Path.GetExtension(ofd.SafeFileName);
            if (extension == ".txt")
                CreateTextBox(ofd, form);
            else if (NextPreviewer != null)
                NextPreviewer.HandleFileType(ofd, form);
        }

        TextBox textBox;
        private void CreateTextBox(OpenFileDialog ofd, Form form)
        {
            string fileContent="";
            using (StreamReader reader = new StreamReader(ofd.OpenFile()))
            {
                fileContent = reader.ReadToEnd();
            }

            textBox = new TextBox();
            textBox.Location = new System.Drawing.Point(12, 54);
            textBox.Size = new System.Drawing.Size(617, 330);
            textBox.ScrollBars = ScrollBars.Vertical;
            textBox.Multiline = true;
            form.Controls.Add(textBox);
            textBox.Text = fileContent;

        }
    }
}
