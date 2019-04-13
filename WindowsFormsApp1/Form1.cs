using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Analyzer;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Function F { get; private set; } 
        TextBoxWork text = new TextBoxWork();
        public Form1()
        {
            InitializeComponent();
            foreach (Control item in MainPanel.Controls)
            {
                if (item is TextBox)
                {
                    item.Click += text.Click;
                    item.LostFocus += text.LostFocus;
                    text.Add((TextBox)item);
                }
            }

        }


        private void SetFunctionButton_Click(object sender, EventArgs e)
        {
            SetFunction set = new SetFunction();
            if (set.ShowDialog() == DialogResult.OK)
            {
                F = set.F;
                FLabel.Text = F.Tostring();
            }
        }

        private void SaveFunctionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(F != null)
            {
                SaveFileDialog dialog = new SaveFileDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    Stream stream = File.Open(dialog.FileName, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
                    formatter.Serialize(stream, F);
                    stream.Close();
                }
            }
            else
            {
                MessageBox.Show("Please load a function and try again", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        private void OpenFunctionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void DrawButton_Click_1(object sender, EventArgs e)
        {
            double StartX = double.Parse(XBox.Text);
            double DX = double.Parse(DXBox.Text);
            double Step = double.Parse(StepBox.Text);
            double Start = double.Parse(StartBox.Text);
            double End = double.Parse(EndBox.Text);
            FView.Series[0].Points.Clear();
            for(double i = Start;i< End; i+= Step)
            {
                double y = 0;
                double x = StartX + i;
                y = F.TryCalculate(x);
                FView.Series[0].Points.AddXY(x, y);
            }
        }
    }


}
