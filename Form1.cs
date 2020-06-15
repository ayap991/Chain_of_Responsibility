using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                //
            }

        }
    }
}
