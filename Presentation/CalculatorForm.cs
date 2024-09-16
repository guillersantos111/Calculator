using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CalculatorForm : System.Windows.Forms.Form
    {
        double resultValue = 0;
        string performOperation = "";
        bool operationIsPerformed = false;

        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void BTN_NUMBERANDDOT(object sender, EventArgs e)
        {
            if (TB_DISPLAY.Text == "" || (operationIsPerformed))
            {
                TB_DISPLAY.Clear();
            }

            operationIsPerformed = false;

            KryptonButton kryptonButton = (KryptonButton)sender;

            if (kryptonButton.Text == "")
            {
                if (!TB_DISPLAY.Text.Contains("."))
                {
                    TB_DISPLAY.Text += kryptonButton.Text;
                }
            }
            else
            {
                TB_DISPLAY.Text += kryptonButton.Text;
            }
        }


        private void BTN_DELETE_Click(object sender, EventArgs e)
        {
            if (TB_DISPLAY.Text.Length > 0)
            {
                TB_DISPLAY.Text = TB_DISPLAY.Text.Remove(TB_DISPLAY.Text.Length - 1, 1);
            }
        }


        private void BTN_OPERATORS_CLICK(object sender, EventArgs e)
        {
            KryptonButton button = (KryptonButton)sender;

            performOperation = button.Text;
            resultValue = Double.Parse(TB_DISPLAY.Text);
            operationIsPerformed = true;
            LBL_DISPLAYRESULT.Text = resultValue + " " + performOperation;
        }


        private void BTN_EQUALS_Click(object sender, EventArgs e)
        {
            if (performOperation == "+")
            {
                TB_DISPLAY.Text = (resultValue + double.Parse(TB_DISPLAY.Text)).ToString();
            }
            else if (performOperation == "-")
            {
                TB_DISPLAY.Text = (resultValue - double.Parse(TB_DISPLAY.Text)).ToString();
            }
            else if (performOperation == "*")
            {
                TB_DISPLAY.Text = (resultValue * double.Parse(TB_DISPLAY.Text)).ToString();
            }
            else
            {
                TB_DISPLAY.Text = (resultValue / double.Parse(TB_DISPLAY.Text)).ToString();
            }
        }


        private void BTN_CLEAR_Click(object sender, EventArgs e)
        {
            ClearTextBoxHelper.Clear(this);
        }
    }
}
