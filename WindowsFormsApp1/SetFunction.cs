using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SetFunction : Form
    {
        public SetFunction()
        {
            InitializeComponent();
        }

        private void Analyzerbutton_Click(object sender, EventArgs e)
        {
            Consolebox.Text += "\r\nhello world";
        }
    }
}
