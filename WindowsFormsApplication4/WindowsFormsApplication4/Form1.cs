using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class txtboxResult : Form
    {
        public string strOperator = "";
        public string strOperand1 = "";
        public string strOperand2 = "";
        public txtboxResult()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void txtboxResult_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void NumberClick(object sender, EventArgs e)
        {


            //cast to convert object to Button
            Button bt = (Button)sender;

            //append the digits
            tbxResult.AppendText(bt.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double dOperand2 = double.Parse(tbxResult.Text);
            //tbxResult.Clear();

            double dOperand1 = double.Parse(strOperand1);

            double result = 0;
            if (strOperator == "+")

            {
                result = dOperand1 + dOperand2;
            }

            if (strOperator == "/")

            {
                result = dOperand1 / dOperand2;
            }

            if (strOperator == "*")

            {
                result = dOperand1 * dOperand2;
            }
            if (strOperator == "-")

            {
                result = dOperand1 - dOperand2;
            }

            tbxResult.Text = result.ToString();
    
        }

        private void btDivide_Click(object sender, EventArgs e)
        {
            strOperator = btDivide.Text;

            strOperand1 = tbxResult.Text;

            tbxResult.Clear();

            //MessageBox.Show("Operator " + strOperator);

            //MessageBox.Show("First Operand " + strOperand1);
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            tbxResult.Clear();
        }

        private void btPlus_Click(object sender, EventArgs e)
        {

            strOperator = btPlus.Text;

            strOperand1 = tbxResult.Text;

            tbxResult.Clear();

            //MessageBox.Show("Operator " + strOperator);

            //MessageBox.Show("First Operand " + strOperand1);
        }

        private void btSubtract_Click(object sender, EventArgs e)
        {
            strOperator = btSubtract.Text;

            strOperand1 = tbxResult.Text;

            tbxResult.Clear();

            //MessageBox.Show("Operator " + strOperator);

            //MessageBox.Show("First Operand " + strOperand1);
        }

        private void btMultiply_Click(object sender, EventArgs e)
        {
            strOperator = btMultiply.Text;

            strOperand1 = tbxResult.Text;

            tbxResult.Clear();

            //MessageBox.Show("Operator " + strOperator);

            //MessageBox.Show("First Operand " + strOperand1);
        }

        private void btDecimal_Click(object sender, EventArgs e)
        {
            tbxResult.AppendText(".");
        }
    }
    }
    

