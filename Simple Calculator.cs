using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Object_Oriented_Project_S2
{    //Name:Arshath Wuvais
    //Date:2023=07-21
    //Description:Cal WebForm
    public partial class Simple_Calculator : Form
    {
        public Simple_Calculator()
        {
            InitializeComponent();
        }

        Calculator user = new Calculator();
        string symbole = "";


        private void ButtonEnable()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
        }
        private void Simple_Calculator_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Text = "1";
            textBox1.Text += button8.Text;
            textBox2.Text += button8.Text;
            ButtonEnable();



        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.Text = "2";
            textBox1.Text += button12.Text;
            textBox2.Text += button12.Text;
            ButtonEnable();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button16.Text = "3";
            textBox1.Text += button16.Text;
            textBox2.Text += button16.Text;
            ButtonEnable();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Text = "4";
            textBox1.Text += button9.Text;
            textBox2.Text += button9.Text;
            ButtonEnable();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button13.Text = "5";
            textBox1.Text += button13.Text;
            textBox2.Text += button13.Text;
            ButtonEnable();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            button17.Text = "6";
            textBox1.Text += button17.Text;
            textBox2.Text += button17.Text;
            ButtonEnable();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.Text = "7";
            textBox1.Text += button10.Text;
            textBox2.Text += button10.Text;
            ButtonEnable();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button14.Text = "8";
            textBox1.Text += button14.Text;
            textBox2.Text += button14.Text;
            ButtonEnable();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            button18.Text = "9";
            textBox1.Text += button18.Text;
            textBox2.Text += button18.Text;
            ButtonEnable();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.Text = "0";
            textBox1.Text += button11.Text;
            textBox2.Text += button11.Text;
            ButtonEnable();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button15.Text = ".";
            textBox1.Text += ".";
            textBox2.Text += ".";
            button15.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "+";
            symbole = button1.Text;
            textBox1.Text += button1.Text;
            user.Add(Convert.ToDecimal(textBox2.Text));
            textBox2.Text = "";
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button15.Enabled = true;
            button5.Enabled = true;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = "-";
            symbole = button2.Text;
            textBox1.Text += button2.Text;
            user.Subtract(Convert.ToDecimal(textBox2.Text));
            textBox2.Text = "";
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button15.Enabled = true;
            button5.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = "x";
            symbole = "*";
            textBox1.Text += button3.Text;
            user.Multiply(Convert.ToDecimal(textBox2.Text));
            textBox2.Text = "";
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button15.Enabled = true;
            button5.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = "/";
            symbole = button4.Text;
            textBox1.Text += button4.Text;
            user.Divide(Convert.ToDecimal(textBox2.Text));
            textBox2.Text = "";
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button15.Enabled = true;
            button5.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            if (textBox2.Text == "")
            {

                if (symbole == "+") { user.Add(Convert.ToDecimal("0")); }
                else if (symbole == "-") { user.Subtract(Convert.ToDecimal("0")); }
                else if (symbole == "*") { user.Multiply(Convert.ToDecimal("0")); }
                else if (symbole == "/") { user.Divide(Convert.ToDecimal("0")); }

                if (symbole == "/" && user.Equals().ToString() == "0")
                {
                    textBox1.Text = "Impossible";
                    textBox2.Text = "Impossible";
                }
                else
                {
                    textBox2.Text = user.Equals().ToString();
                    textBox1.Text += "0=" + textBox2.Text;
                }

            }
            else
            {
                if (symbole == "+") { user.Add(Convert.ToDecimal(textBox2.Text)); }
                else if (symbole == "-") { user.Subtract(Convert.ToDecimal(textBox2.Text)); }
                else if (symbole == "*") { user.Multiply(Convert.ToDecimal(textBox2.Text)); }
                else if (symbole == "/") { user.Divide(Convert.ToDecimal(textBox2.Text)); }
                if (symbole == "/" && user.Equals().ToString() == "0")
                {
                    textBox1.Text = "Impossible";
                    textBox2.Text = "Impossible";
                }
                else
                {
                    textBox2.Text = user.Equals().ToString();
                    textBox1.Text += "=" + textBox2.Text;
                }

            }
            button5.Enabled = false;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            user.Clear();
            textBox1.Text = null; textBox2.Text = null;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
            button18.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
