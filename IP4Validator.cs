using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Object_Oriented_Project_S2
{
    //Name:Arshath Wuvais
    //Date:2023=07-21
    //Description:Ip WebForm
    public partial class IP4Validator : Form
    {
        public IP4Validator()
        {
            InitializeComponent();
            string dir = @"C:\Test\";
            //you can use relative path .\ => where the .exe is
            //or ..\ => one folder up where the .exe is.
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
        }
        Regex obj;
        Regex OBJ;
        FileStream fs = null;
        string path = @"C:\Test\IpAddresses.txt";
        string dirPath = @"C:\Test\"; // .\Test
        string filePath = @".\Test\IpAddresses.txt"; // .\Test\Names.txt
        bool correct = false;
        
        private void button1_Click(object sender, EventArgs e)
        {
           
                obj = new Regex(@"^((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$");

            if (obj.IsMatch(textBox1.Text) == true)
            {
                MessageBox.Show(textBox1.Text + "\n" + "The IP is Correct", "IP Validator", MessageBoxButtons.OK);
            }


            else
            {
                OBJ = new Regex(@"^(?:[0-9a-fA-F]{1,4}:){7}[0-9a-fA-F]{1,4}$");
                if (OBJ.IsMatch(textBox2.Text) == false)
                {
                    MessageBox.Show(
               textBox1.Text + "\n" + "The IP must have 4 bytes" + "\n" + "Integer number between 0 and 255" + "\n" + "separated by a dot (255.255.255.255)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                OBJ = new Regex(@"^(?:[0-9a-fA-F]{1,4}:){7}[0-9a-fA-F]{1,4}$");
                if (OBJ.IsMatch(textBox2.Text) == true)
                {
                   
                }
                else
                {
                    MessageBox.Show(
                  textBox1.Text + "\n" + "Invalid IPv6 address" + "\n" + "Please enter a valid IPv6 address in the following format:" + "\n" + "2001:0db8:85a3:0000:0000:8a2e:0370:7334", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }



            }
           
           
                OBJ = new Regex(@"^(?:[0-9a-fA-F]{1,4}:){7}[0-9a-fA-F]{1,4}$");
                if (OBJ.IsMatch(textBox2.Text) == true)
                {
                    MessageBox.Show(textBox2.Text + "\n" + "The IP is Correct", "IP Validator", MessageBoxButtons.OK);
                }
                
                if(obj.IsMatch(textBox1.Text) == true|| OBJ.IsMatch(textBox2.Text) == true)
                {
                    correct = true;
                }
                else
                {
                    correct = false;
                }

                //else
                //{
                //    MessageBox.Show(
                //  textBox1.Text + "\n" + "Invalid IPv6 address" + "\n" + "Please enter a valid IPv6 address in the following format:" + "\n" + "2001:0db8:85a3:0000:0000:8a2e:0370:7334", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                //}
       
           

            

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void IP4Validator_Load(object sender, EventArgs e)
        {
            label1.Text = "Today: " + DateTime.Now.ToLongDateString();
        }
        int value = 0;
        int value1 = 0;
        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                //value = Convert.ToInt32(textBox1.Text);
                //value1 = Convert.ToInt32(textBox2.Text);
                if (correct == true)
                {
                    if (textBox1.Text.Trim() == "0" || textBox2.Text.Trim() == "0")
                    {
                        //button2.Enabled = false;
                        MessageBox.Show("Not Allowed to press button till 1st button igthfvyhfvs pressed.", "ReadMeTextFile", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (textBox1.Text != null || textBox2.Text != null)
                    {
                        try
                        {
                            fs = new FileStream(path, FileMode.Append, FileAccess.Write);
                            // Create the object for the input stream for a text file
                            using (StreamWriter textIn = new StreamWriter(fs))
                            {
                                string text = textBox1.Text;
                                string[] spl = text.Split('.');
                                string v4 = string.Join(".", spl);
                                //int bi = Convert.ToInt32(textBox1.Text);
                                //string binary = Convert.ToString(bi, 2);

                                textIn.WriteLine(DateTime.Now.ToLongDateString() + "\n" + "IPv4: " + v4);

                                string ipv6 = textBox2.Text;
                                string[] v6 = ipv6.Split(':');
                                string v6val = string.Join(":", v6);

                                textIn.WriteLine("IPv6: " + v6val + "\n");

                            }

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
                        {
                            MessageBox.Show(ex.Message, "IOException");
                        }
                        finally
                        {
                            if (fs != null) fs.Close();
                        }
                        //READS
                        try
                        {
                            fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
                            // create the object for the input stream for a text file
                            StreamReader textIn = new StreamReader(fs);
                            string textToPrint = "\tIP Addresses \n\n";
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
                        correct = false;
                    }
                }
                else
                {
                    MessageBox.Show("Not Allowed to press button till validate IP is correct", "ReadMeTextFile", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Text = null;
                    textBox2.Text = null;
                }

              
            }
            catch
            {
                MessageBox.Show("Not Allowed to press button till 1st button is pressed.", "ReadMeTextFile", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = null;
                textBox2.Text = null;
            }
            
            

          
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
