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
    public partial class Form1 : Form
    {
        TextBoxWork text = new TextBoxWork();
        public Form1()
        {
            InitializeComponent();
            foreach(Control item in MainPanel.Controls)
            {
                if(item is TextBox)
                {
                    item.Click += text.Click;
                    item.LostFocus += text.LostFocus;
                    text.Add((TextBox)item);
                }
            }

        }

        private void DrawButton_Click(object sender, EventArgs e)
        {

        }
    }


}
