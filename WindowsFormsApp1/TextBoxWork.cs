using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class TextBoxWork
    {
        public Dictionary<TextBox, string> Boxes { get; private set; } = new Dictionary<TextBox, string>();

        public void Add(KeyValuePair<TextBox, string> pair)
        {
            Boxes.Add(pair.Key, pair.Value);
        }

        public void Add(TextBox box, string text)
        {
            Boxes.Add(box, text);
        }

        public void Add(TextBox box)
        {
            Boxes.Add(box, box.Text);
        }

        public void LostFocus(object sender, EventArgs e)
        {
            if (sender is TextBox control)
            {
                if (Boxes.ContainsKey(control))
                {
                    if (control.Text == "")
                    {
                        control.Text = Boxes[control];
                    }
                }
            }
        }

        public void Click(object sender, EventArgs e)
        {
            if (sender is TextBox control)
            {
                if (Boxes.ContainsKey(control))
                {
                    if (control.Text == Boxes[control])
                    {
                        control.Text = "";
                    }
                }
            }
        }

    }
}
