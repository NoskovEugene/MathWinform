using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Analyzer;

namespace WindowsFormsApp1
{
    public partial class SetFunction : Form
    {

        public Function F { get; private set; }
        

        public SetFunction()
        {
            InitializeComponent();
            ReturnButton.DialogResult = DialogResult.OK;
            TextBoxWork boxWork = new TextBoxWork();
            foreach (Control item in MainPanel.Controls)
            {
                if (item is TextBox control)
                {
                    control.Click += boxWork.Click;
                    control.LostFocus += boxWork.LostFocus;
                    boxWork.Add(control);
                }
            }
        }

        private void Analyzerbutton_Click(object sender, EventArgs e)
        {
            string functionstr = FBox.Text;
            try
            {
                F = new Function(FBox.Text);
                F.ConvertToList();
                F.GetNotation();
                FAfterBox.Text = F.Tostring();
                PolNotBox.Text = F.PolNotTostring();
            }
            catch (Exception ex)
            {
                Consolebox.Text += $"\r\n{ex.Message}";
            }
        }

        private void TryCalcButtion_Click(object sender, EventArgs e)
        {
            bool Succes = false;
            double TestX = double.TryParse(TestXBox.Text, out TestX) ? double.Parse(TestXBox.Text) : double.NaN;

            for (int i = -10; i <= 10; i++)
            {
                Succes = TryCalc(i);
            }
            if (!double.IsNaN(TestX))
            {
                Succes = TryCalc(TestX);
            }
            if (!Succes)
            {
                MessageBox.Show("Suitable X not found. Pleace enter the X and try again.");
            }
            else
            {
                MessageBox.Show("Succes");
                Consolebox.Text += "Succes\r\n";
                ReturnButton.Enabled = true;
            }
        }

        public bool TryCalc(double X)
        {
            Consolebox.Text += $"Trying calculate function with X = {X}\r\n";
            try
            {
                F.TryCalculate(X);
                return true;
            }
            catch (Exception ex)
            {
                Consolebox.Text += $"{ex.Message}\r\n";
            }
            return false;
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
