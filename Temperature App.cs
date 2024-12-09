using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Object_Oriented_Project_S2
{
    //NAME:Arshath Wuvais
    //Date:2023=07-17
    //Desc: Conversions from C to F
    public partial class Temperature_App : Form
    {
        public Temperature_App()
        {
            InitializeComponent();
            string dir = @"C:\Test\";
            //you can use relative path .\ => where the .exe is
            //or ..\ => one folder up where the .exe is.
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
        }
        FileStream fs = null;
        string path = @"C:\Test\TempConversions.txt";
        string dirPath = @"C:\Test\"; // .\Test
        string filePath = @".\Test\TempConversions.txt"; // .\Test\Names.txt
        decimal[] anumbers = new decimal[5];
        string[] message = new string[5];
        decimal[] user = new decimal[5];
        double value = 0;
        double value1 = 0;
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                value = Convert.ToDouble(textBox2.Text);
                value1 = Convert.ToDouble(textBox1.Text);
                if (textBox2.Text == "0" || textBox2.Text == null)
                {
                    //button2.Enabled = false;
                    MessageBox.Show("Not Allowed to press button till 1st button is pressed.", "ReadMeTextFile", MessageBoxButtons.OK, MessageBoxIcon.Error);



                }
                else
                {

                    DateTime now = DateTime.Now;
                    string longTimeString = now.ToLongTimeString();
                    string toshortdatestring = now.ToShortDateString();

                    try
                    {
                        fs = new FileStream(path, FileMode.Append, FileAccess.Write);
                        // create the object for the input stream for a text file
                        StreamWriter textIn = new StreamWriter(fs);
                        //textIn.Write(textBox1.Text + "|");
                        //textIn.WriteLine(textBox1.Text);


                        string line = "";


                        int i = 0;
                        int z = 0;
                        int j = 0;

                        line = user[j].ToString("0.00") + " C = " + anumbers[i].ToString("0.00") + " F, " + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString() + " " + message[z] + "\n";
                        i++;
                        z++;

                        textIn.Write(line);
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
                        string textToPrint = "\t\t   Temp Conversions \n\n";
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
            catch
            {
                MessageBox.Show("Please Enter Numerical Value", "ReadMeTextFile", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = null;
                textBox2.Text = null;
                textBox3.Text = null;
            }
           
            

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                Temperature_Conversion obj = new Temperature_Conversion();
                obj.ShowDialog();
                radioButton1.Checked = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            double userInput = 0;
            double result = 0;
            int i = 0;
            int z = 0;
            int j = 0;
            
            if (radioButton1.Checked)
            {
                try
                {
                    userInput = Convert.ToDouble(textBox2.Text);
                    result = (userInput * (1.8) + 32);
                    textBox1.Text = result.ToString("0.00");
                    user[j] = Convert.ToDecimal(userInput);
                    anumbers[i] = Convert.ToDecimal(result);
                    
                    i++;
                    if (result == 212)
                    {
                        message[z] = textBox3.Text = "Water Boils";
                    }
                    else if (result == 104)
                    {
                        message[z] = textBox3.Text = "Hot Bath";
                    }
                    else if (userInput == 37)
                    {
                        message[z] = textBox3.Text = "Body temperature";
                    }
                    else if (result == 86)
                    {
                        message[z] = textBox3.Text = "Beach weather";
                    }
                    else if (result == 70)
                    {
                        message[z] = textBox3.Text = "Room temperature";
                    }
                    else if (result == 50)
                    {
                        message[z] = textBox3.Text = "Cool day";
                    }
                    else if (result == 32)
                    {
                         textBox3.Text = "Freezing point of water";
                    }



                    else if (result == 0)
                    {
                        message[z] = textBox3.Text = "Very cold day";
                    }
                    else if (result == -40)
                    {
                        message[z] = textBox3.Text = "Extremely cold day";
                    }
                    else
                    {
                        try
                        {
                            if (userInput != null)
                            {
                                message[z] = textBox3.Text = "Temperature Converted";

                            }
                        }
                        catch
                        {
                            MessageBox.Show("Please Enter Numerical Values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBox1.Text = null;
                            textBox2.Text = null;
                            textBox3.Text = null;
                        }

                    }
                }
                catch
                {
                    MessageBox.Show("Please Enter Numerical Values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Text = null;
                    textBox2.Text = null;
                    textBox3.Text = null;
                }
                

            }
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Temperature_App_Load(object sender, EventArgs e)
        {

        }
    }
}
