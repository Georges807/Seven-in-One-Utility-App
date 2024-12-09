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
{
    //Name:Arshath Wuvais
    //Date:2023-07-12
    //Description:Dashboard
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to quit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
            {
                this.Close(); ;//or Environment.Exit(0)//
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMax obj = new frmMax();
            obj.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm649 obj = new frm649();
            obj.ShowDialog();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Money_Exchange obj = new Money_Exchange();
            obj.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Temperature_App obj = new Temperature_App();
            obj.ShowDialog();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Simple_Calculator obj = new Simple_Calculator();
            obj.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            IP4Validator obj = new IP4Validator();
            obj.ShowDialog();
        }
    }
}
