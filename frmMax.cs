using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Object_Oriented_Project_S2
{
    //Name:Arshath Wuvais
    //Date:2023-07-12
    //Description:LottoMax
    public partial class frmMax : Form
    {
        public frmMax()
        {
            InitializeComponent();
            
            string dir = @"C:\Test\";
            //you can use relative path .\ => where the .exe is
            //or ..\ => one folder up where the .exe is.
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
        }

        private void frmMax_Load(object sender, EventArgs e)
        {
           
        }
        FileStream fs = null;
        string path = @"C:\Test\LottoNbrs.txt";
        string dirPath = @"C:\Test\"; // .\Test
        string filePath = @".\Test\LottoNbrs.txt"; // .\Test\Names.txt
        int[] anumbers = new int[8];
       
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int randomNumber = 0;
            string numbers = "";
            int[] duplicate = new int[8];
            bool duplicate2 = false;
            Random random = new Random();
            int count = 0;
            int hh = 0;


            while (count < 8)
            {
                duplicate2 = false;
                randomNumber = random.Next(1, 49);
                duplicate[count] = randomNumber;

                for (int x = 0; x < count; x++)
                {
                    if (duplicate[x] == randomNumber)
                    {
                        duplicate2 = true;

                    }
                }

                if (!duplicate2)
                {
                    numbers += randomNumber.ToString() + "\t";
                    anumbers[hh] = randomNumber;
                    hh++;
                    count++;
                }
            }

            textBox1.Text = numbers;
           
        } 

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                //button2.Enabled = false;
                MessageBox.Show("Not Allowed to press button till 1st button is pressed.", "ReadMeTextFile", MessageBoxButtons.OK, MessageBoxIcon.Error);



            }
            else
            {
               
                try
                {
                    fs = new FileStream(path, FileMode.Append, FileAccess.Write);
                    // create the object for the input stream for a text file
                    StreamWriter textIn = new StreamWriter(fs);
                    //textIn.Write(textBox1.Text + "|");
                    //textIn.WriteLine(textBox1.Text);
                    textIn.Write("Max, ");
                    textIn.Write(DateTime.Now.ToString() + ",  ");
                    for (int i = 0; i < anumbers.Length - 1; i++)
                    {
                        textIn.Write(anumbers[i] + ",")/* + columns[1] + "\n"*/;
                    }
                    textIn.WriteLine("Extra " + anumbers[anumbers.Length - 1]);
                    // textIn = new StreamReader(fs);
                    textIn.Close();



                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show(filePath + " not found.", "File Not Found");
                }
                catch (DirectoryNotFoundException)
                {
                    MessageBox.Show(dirPath + " not found.", "Directory Not Found");
                }
                catch (IOException ex)
                { MessageBox.Show(ex.Message, "IOException"); }
                finally { if (fs != null) fs.Close(); }




                //READS
                try
                {
                    fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
                    // create the object for the input stream for a text file
                    StreamReader textIn = new StreamReader(fs);
                    string textToPrint = "\t\tLottery Numbers: \n\n";
                    // read the data from the file and store it in the list
                    while (textIn.Peek() != -1)
                    {
                        string row = textIn.ReadLine();
                        textToPrint += row + "\n";
                        //string[] columns = row.Split();
                        //textToPrint = "649, " + DateTime.Now.ToString() + ", ";
                        //for (int i = 0; i < columns.Length - 2; i++)
                        //{
                        //    textToPrint += columns[i] + ","/* + columns[1] + "\n"*/;
                        //}
                        //textToPrint += "Extra "+columns[columns.Length-1];



                    }
                    MessageBox.Show(textToPrint);
                    // close the input stream for the text file
                    textIn.Close();





                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show(filePath + " not found.", "File Not Found");
                }
                catch (DirectoryNotFoundException)
                {
                    MessageBox.Show(dirPath + " not found.", "Directory Not Found");
                }
                catch (IOException ex)
                { MessageBox.Show(ex.Message, "IOException"); }
                finally { if (fs != null) fs.Close(); }


            }


        }

            private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
