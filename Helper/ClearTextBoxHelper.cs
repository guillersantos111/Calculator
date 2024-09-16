using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public static class ClearTextBoxHelper
    {

        private static readonly IEnumerable<Control> Control;

        public static void Clear(Control controls)
        {

            foreach (Control control in controls.Controls)
            {
                switch (control)
                {
                    case TextBox textBox:
                        textBox.Clear();
                        break;
                    case Label label:
                        label.Text = string.Empty;
                        break;
                }
                if (control.HasChildren)
                {
                    Clear(control);
                }
            }
        }
    }
}
