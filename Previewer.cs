using System.Windows.Forms;

namespace Chain_of_Responsibility
{
    abstract public class Previewer
    {
        protected Previewer NextPreviewer;
        public void SetNextPreviewer(Previewer nextPreviewer)
        {
            this.NextPreviewer = nextPreviewer;
        }
        public abstract void HandleFileType(OpenFileDialog ofd, Form form);
    }
}
