using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        double ResultValue = 0;
        string Operationperformed = " ";
        bool isoperationformed = false; 
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttoncllick(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (isoperationformed)) 
                textBox1.Clear();
            isoperationformed = false; 
                Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            double a = Double.Parse(textBox1.Text);
            if (OP.prime(a))
                textBox1.Text = "It's prime";
            else
                textBox1.Text = "It's NOT prime";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            int b = int.Parse(textBox1.Text);
            if (OS.number(b))
                textBox1.Text = "Number is greater than 10"; 
            else
                textBox1.Text = "Number is less than 10";



        }

        private void operations(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Operationperformed = button.Text;
            ResultValue = Double.Parse(textBox1.Text);
            isoperationformed = true; 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            ResultValue = 0;

        }

        private void button19_Click(object sender, EventArgs e)
        {
            switch (Operationperformed)

            {
                case "+":
                    textBox1.Text = (ResultValue + Double.Parse(textBox1.Text)).ToString();
                    break;

                case "-":
                    textBox1.Text = (ResultValue - Double.Parse(textBox1.Text)).ToString();
                    break;

                case "X":
                    textBox1.Text = (ResultValue * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (ResultValue / Double.Parse(textBox1.Text)).ToString();
                    break;

                default:
                    break;
            }



            }
        }
    
    }
