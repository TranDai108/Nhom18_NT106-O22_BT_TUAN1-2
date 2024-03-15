using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        double result = 0;
        string operationperform = "";
        bool isoperation = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (operationperform == "+")
            {
                Displayresbox.Text = (result + double.Parse(Displayresbox.Text)).ToString();
            }
            if (operationperform == "-")
            {
                Displayresbox.Text = (result - double.Parse(Displayresbox.Text)).ToString();
            }
            if (operationperform == "x")
            {
                Displayresbox.Text = (result * double.Parse(Displayresbox.Text)).ToString();
            }
            if (operationperform == "/")
            {
                Displayresbox.Text = (result / double.Parse(Displayresbox.Text)).ToString();
            }
            if (operationperform == null)
            {
                Displayresbox.Text = Displayresbox.Text;
            }
        }

        private void Click_button(object sender, EventArgs e)
        {
            
            
            Button button = (Button)sender;
            if (Displayresbox.Text == "0" || (isoperation))
            {
                if (button.Text != ".")
                    Displayresbox.Clear();
            }
            isoperation = false;
            
            if (button.Text == ".")
            {
                
                if (!Displayresbox.Text.Contains("."))
                    Displayresbox.Text += button.Text;
            }
            else
            {
                Displayresbox.Text += button.Text;
            }
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operationperform = button.Text;
            isoperation = true;
            result = Double.Parse(Displayresbox.Text); 
            if (operationperform == "/")
                label.Text = result + " ÷";
            else
                label.Text = result + " " + operationperform;
            isoperation = true;

        }

        private void button17_Click(object sender, EventArgs e)
        {
            Displayresbox.Text = "0";
            label.Text = "0";
            result = 0;
            operationperform = null;
            isoperation = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(Displayresbox.Text) > 0 || Displayresbox.Text.Contains("."))
                Displayresbox.Text = Displayresbox.Text.Remove(Displayresbox.Text.Length - 1, 1);
   
            if (Displayresbox.Text == "" || Displayresbox.Text == "0.")
            {
                Displayresbox.Clear();
                Displayresbox.Text = "0";
            }
        }
    }
}
