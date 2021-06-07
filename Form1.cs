using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string input1 = textBox1.Text;
            string input2 = textBox2.Text;

            int i1 = 0;
            Int32.TryParse(input1, out i1);

            int i2 = 0;
            Int32.TryParse(input2, out i2); 

            string operation = textBox3.Text;


            switch (operation)
            {
                case "+":
                    textBox4.Text = Add(i1,i2);
                    break;
                case "-":
                    textBox4.Text = Subtract(i1,i2);
                    break;
                case "*":
                    textBox4.Text = Multiply(i1,i2);
                    break;
                case "/":
                    textBox4.Text = Divide(i1,i2);
                    break;
                case "%":
                    textBox4.Text = Modulo(i1,i2);
                    break;
            }
        }
        private string Add(int num1, int num2)
        {
            int o = num1 + num2;
            return Conversion(o);
            
        }
        private string Subtract(int num1,int num2)
        {
            int o = num1 - num2;
            return Conversion(o);
        }
        private string Multiply(int num1,int num2)
        {
            int o = num1 * num2;
            return Conversion(o);
        }
        private string Divide(int num1, int num2)
        {
            int o = num1 / num2;
            return Conversion(o);
        }
        private string Modulo(int num1, int num2)
        {
            int o = num1 % num2;
            return Conversion(o);
        }
        private string Conversion(int t)
        {
            string o = Convert.ToString(t);
            return o;
        }
    }  
}
