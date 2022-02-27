using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _270222_CalculatorApp
{
    public partial class Form1 : Form
    {
        bool optSituation= false;
        double result = 0;
        string operation = " ";
        public Form1()
        {
            InitializeComponent();
        }

        private void numberEvent(object sender, EventArgs e)
        {
            if(txtResult.Text == "0" || optSituation)
            {
                txtResult.Clear();  
            }
            optSituation = false;   
            Button btn = (Button)sender;
            txtResult.Text += btn.Text;
        }

        private void optCalculation(object sender, EventArgs e)
        {
            optSituation= true;    
            Button btn = (Button)sender;
            string newOperation = btn.Text;
            lblResult.Text = lblResult.Text + " " + txtResult.Text + " " + newOperation;
            switch(operation)
            {
                case "+": txtResult.Text = (result + double.Parse(txtResult.Text)).ToString();
                    break;
                case "-":
                    txtResult.Text = (result - double.Parse(txtResult.Text)).ToString();
                    break;
                case "*":
                    txtResult.Text = (result * double.Parse(txtResult.Text)).ToString();
                    break;
                case "/":
                    txtResult.Text = (result / double.Parse(txtResult.Text)).ToString();
                    break;
            }
            result = double.Parse(txtResult.Text);   
            txtResult.Text= result.ToString();  
            operation = newOperation;   
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            lblResult.Text = " ";
            operation = " ";
            result = 0;
            optSituation = false;   
        }

        private void button16_Click(object sender, EventArgs e)
        {
            lblResult.Text = " ";
            optSituation=true;  
            switch (operation)
            {
                case "+":
                    txtResult.Text = (result + double.Parse(txtResult.Text)).ToString();
                    break;
                case "-":
                    txtResult.Text = (result - double.Parse(txtResult.Text)).ToString();
                    break;
                case "*":
                    txtResult.Text = (result * double.Parse(txtResult.Text)).ToString();
                    break;
                case "/":
                    txtResult.Text = (result / double.Parse(txtResult.Text)).ToString();
                    break;
            }
            result = double.Parse(txtResult.Text);
            txtResult.Text = result.ToString();
            operation = " ";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if(txtResult.Text == "0")
            {
                txtResult.Text= "0";    
            }
            else if (optSituation == true)
            {
                txtResult.Text = "0";
            }

            if(! txtResult.Text.Contains(","))
            {
                txtResult.Text+=",";    
            }
            optSituation = false;   
        }
    }
}
