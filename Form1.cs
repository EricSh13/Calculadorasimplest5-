using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Calculadora_simples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void btnCop_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(buttons.Text);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textDisplay.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text.Length > 0)
            {
                textDisplay.Text = textDisplay.Text.Remove(buttons.Text.Length - 1, 1);
            }
        }

        private void btnNum(object btn, EventArgs e)
        {
            textDisplay.Text += (btn as Button).Text;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (continhaAnterior == Operations.None)
            {
                continhaAnterior = Operations.Div;
            }
            else
            {
                FazerContinha(continhaAnterior);
            }
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            if (continhaAnterior == Operations.None)
            {
                continhaAnterior = Operations.Mul;
            }
            else
            {
                FazerContinha(continhaAnterior);
            }
        }
        private void btnSum_Click(object sender, EventArgs e)
        {
            if (continhaAnterior == Operations.None)
            {
                continhaAnterior = Operations.Add;
            }
            else
            {
                FazerContinha(continhaAnterior);
            }
            textDisplay.Text += (sender as Button).Text;
        }

        private void FazerContinha(Operations continhaAnterior)
        {

            List<double> lstNums = new List<double>();
            switch (continhaAnterior)
            {
                case Operations.Add:
                    lstNums = textDisplay.Text.Split('+').Select(double.Parse).ToList();
                    textDisplay.Text = (lstNums[0] + lstNums[1]).ToString();
                    break;
                case Operations.Sub:
                    lstNums = textDisplay.Text.Split('-').Select(double.Parse).ToList();
                    textDisplay.Text = (lstNums[0] - lstNums[1]).ToString();
                    break;
                case Operations.Mul:
                    lstNums = textDisplay.Text.Split('X').Select(double.Parse).ToList();
                    textDisplay.Text = (lstNums[0] * lstNums[1]).ToString();
                    break;
                case Operations.Div:
                    break;
                case Operations.None:
                    break;
                default:
                    break;
            }
        }

        enum Operations
        {
            Add,
            Sub,
            Mul,
            Div,
            None
        }

        static Operations continhaAnterior = Operations.None;

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (continhaAnterior == Operations.None)
            {
                continhaAnterior = Operations.Sub;
            }
            else
            {
                FazerContinha(continhaAnterior);
            }
        }
    }
}
