using System;
using System.CodeDom.Compiler;
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

namespace Object_Oriented_Project_S2
{
    //Name:Arshath Wuvais
    //Date:2023-07-12
    //Description:Project-CurrencyExchange
    public partial class Money_Exchange : Form
    {
        public Money_Exchange()
        {
            InitializeComponent();
            string dir = @"C:\Test\";
            //you can use relative path .\ => where the .exe is
            //or ..\ => one folder up where the .exe is.
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
        }
        FileStream fs = null;
        string path = @"C:\Test\MoneyConversions.txt";
        string dirPath = @"C:\Test\"; // .\Test
        string filePath = @".\Test\MoneyConversions.txt"; // .\Test\Names.txt
        decimal[] anumbers = new decimal[8];
        decimal[] user = new decimal[36];
        
        
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            int option = 0;
            double userInput = 0;
            double result = 0;
            int i = 0;
            int j = 0;
            if (radioButton1.Checked)
            {
                option = 1;
            }
            else if (radioButton2.Checked)
            {
                option = 2;
            }
            else if (radioButton3.Checked)
            {
                option = 3;
            }
            else if (radioButton4.Checked)
            {
                option = 4;
            }
            else if (radioButton5.Checked)
            {
                option = 5;
            }

            try
            {
                userInput = Convert.ToDouble(textBox1.Text);

                if(userInput <= 0)
                {
                    MessageBox.Show("Enter positive integers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Text = null;
                    textBox2.Text = null;
                    textBox3.Text = null;
                    textBox4.Text = null;
                    textBox5.Text = null;
                    textBox6.Text = null;
                    textBox7.Text = null;

                }
                else
                {
                    switch (option)
                    {
                        case 1:
                            #region CANADA CONVERSIONS

                            try
                            {

                                //Canada
                                userInput = Convert.ToDouble(textBox1.Text);
                                textBox2.Text = userInput.ToString("0.00");
                               
                                anumbers[i] = Convert.ToDecimal(userInput);
                                i++;

                                //USA
                                userInput = Convert.ToDouble(textBox1.Text);
                                result = (userInput / 133) * 100;
                                textBox5.Text = result.ToString("0.00");
                                user[j] = Convert.ToDecimal(userInput);
                                anumbers[i] = Convert.ToDecimal(result);

                                i++;

                                //EUR
                                userInput = Convert.ToDouble(textBox1.Text);
                                result = (userInput / 149) * 100;
                                textBox3.Text = result.ToString("0.00");
                                user[j] = Convert.ToDecimal(userInput);
                                anumbers[i] = Convert.ToDecimal(result);
                                i++;

                                //GBP
                                userInput = Convert.ToDouble(textBox1.Text);
                                result = (userInput / 173) * 100;
                                textBox6.Text = result.ToString("0.00");
                                user[j] = Convert.ToDecimal(userInput);
                                anumbers[i] = Convert.ToDecimal(result);
                                i++;

                                //Roubles
                                userInput = Convert.ToDouble(textBox1.Text);
                                result = (userInput * 68.2695);
                                textBox4.Text = result.ToString("0.00");
                                user[j] = Convert.ToDecimal(userInput);
                                anumbers[i] = Convert.ToDecimal(result);
                                i++;

                                //YEN
                                userInput = Convert.ToDouble(textBox1.Text);
                                result = (userInput * 5.4015);
                                textBox7.Text = result.ToString("0.00");
                                user[j] = Convert.ToDecimal(userInput);
                                anumbers[i] = Convert.ToDecimal(result);
                                i++;
                            }
                            catch (FormatException ex)
                            {
                                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                textBox1.Text = null;
                                textBox2.Text = null;
                                textBox3.Text = null;
                                textBox4.Text = null;
                                textBox5.Text = null;
                                textBox6.Text = null;
                                textBox7.Text = null;
                            }



                            break;

                        #endregion
                        case 2:
                            #region USD CONVERSION

                            try
                            {

                                //Canada
                                userInput = Convert.ToDouble(textBox1.Text);
                                result = (userInput * 1.3215);
                                textBox2.Text = result.ToString("0.00");
                                user[j] = Convert.ToDecimal(userInput);
                                anumbers[i] = Convert.ToDecimal(result);
                                i++;


                                //USD
                                userInput = Convert.ToDouble(textBox1.Text);
                                textBox5.Text = userInput.ToString("0.00");
                                anumbers[i] = Convert.ToDecimal(userInput);
                                i++;

                                //Eur
                                userInput = Convert.ToDouble(textBox1.Text);
                                result = (userInput * 0.8904);
                                textBox3.Text = result.ToString("0.00");
                                anumbers[i] = Convert.ToDecimal(result);
                                user[j] = Convert.ToDecimal(userInput);
                                i++;

                                //Gbp
                                userInput = Convert.ToDouble(textBox1.Text);
                                result = (userInput * 0.7632);
                                textBox6.Text = result.ToString("0.00");
                                user[j] = Convert.ToDecimal(userInput);
                                anumbers[i] = Convert.ToDecimal(result);
                                i++;

                                //Roubles
                                userInput = Convert.ToDouble(textBox1.Text);
                                result = (userInput * 90.2455);
                                textBox4.Text = result.ToString("0.00");
                                user[j] = Convert.ToDecimal(userInput);
                                anumbers[i] = Convert.ToDecimal(result);
                                i++;

                                //Yen
                                userInput = Convert.ToDouble(textBox1.Text);
                                result = (userInput * 7.1403);
                                textBox7.Text = result.ToString("0.00");
                                user[j] = Convert.ToDecimal(userInput);
                                anumbers[i] = Convert.ToDecimal(result);
                                i++;
                            }
                            catch (FormatException ex)
                            {
                                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                textBox1.Text = null;
                                textBox2.Text = null;
                                textBox3.Text = null;
                                textBox4.Text = null;
                                textBox5.Text = null;
                                textBox6.Text = null;
                                textBox7.Text = null;
                            }
                            break;
                        #endregion
                        case 3:
                            #region EUROS CONVERSION

                            try
                            {//CAD
                                userInput = Convert.ToDouble(textBox1.Text);
                                result = (userInput * 1.48);
                                textBox2.Text = result.ToString("0.00");
                                user[j] = Convert.ToDecimal(userInput);
                                anumbers[i] = Convert.ToDecimal(result);
                                i++;

                                //USA
                                userInput = Convert.ToDouble(textBox1.Text);
                                result = (userInput * 1.12);
                                textBox5.Text = result.ToString("0.00");
                                user[j] = Convert.ToDecimal(userInput);
                                anumbers[i] = Convert.ToDecimal(result);
                                i++;

                                //EUROS
                                userInput = Convert.ToDouble(textBox1.Text);
                                textBox3.Text = userInput.ToString("0.00");
                                anumbers[i] = Convert.ToDecimal(userInput);
                                i++;

                                //Gbp
                                userInput = Convert.ToDouble(textBox1.Text);
                                result = (userInput * 0.86);
                                textBox6.Text = result.ToString("0.00");
                                user[j] = Convert.ToDecimal(userInput);
                                anumbers[i] = Convert.ToDecimal(result);
                                i++;

                                //Roubles
                                userInput = Convert.ToDouble(textBox1.Text);
                                result = (userInput * 101.35);
                                textBox4.Text = result.ToString("0.00");
                                user[j] = Convert.ToDecimal(userInput);
                                anumbers[i] = Convert.ToDecimal(result);
                                i++;

                                //CNY
                                userInput = Convert.ToDouble(textBox1.Text);
                                result = (userInput * 8.02);
                                textBox7.Text = result.ToString("0.00");
                                user[j] = Convert.ToDecimal(userInput);
                                anumbers[i] = Convert.ToDecimal(result);
                                i++;
                            }
                            catch (FormatException ex)
                            {
                                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                textBox1.Text = null;
                                textBox2.Text = null;
                                textBox3.Text = null;
                                textBox4.Text = null;
                                textBox5.Text = null;
                                textBox6.Text = null;
                                textBox7.Text = null;
                            }
                            break;
                        #endregion
                        case 4:
                            #region GBP CONVERSION

                            try
                            {//Cad
                                userInput = Convert.ToDouble(textBox1.Text);
                                result = (userInput * 1.73);
                                textBox2.Text = result.ToString("0.00");
                                user[j] = Convert.ToDecimal(userInput);
                                anumbers[i] = Convert.ToDecimal(result);
                                i++;

                                //USA
                                userInput = Convert.ToDouble(textBox1.Text);
                                result = (userInput * 1.31);
                                textBox5.Text = result.ToString("0.00");
                                user[j] = Convert.ToDecimal(userInput);
                                anumbers[i] = Convert.ToDecimal(result);
                                i++;

                                //Euros
                                userInput = Convert.ToDouble(textBox1.Text);
                                result = (userInput * 1.17);
                                textBox3.Text = result.ToString("0.00");
                                user[j] = Convert.ToDecimal(userInput);
                                anumbers[i] = Convert.ToDecimal(result);
                                i++;

                                //Gbp
                                userInput = Convert.ToDouble(textBox1.Text);
                                textBox6.Text = userInput.ToString("0.00");

                                anumbers[i] = Convert.ToDecimal(userInput);
                                i++;

                                //Roubles
                                userInput = Convert.ToDouble(textBox1.Text);
                                result = (userInput * 118.26);
                                textBox4.Text = result.ToString("0.00");
                                user[j] = Convert.ToDecimal(userInput);
                                anumbers[i] = Convert.ToDecimal(result);
                                i++;

                                {//Yen
                                    userInput = Convert.ToDouble(textBox1.Text);
                                    result = (userInput * 9.36);
                                    textBox7.Text = result.ToString("0.00");
                                    user[j] = Convert.ToDecimal(userInput);
                                    anumbers[i] = Convert.ToDecimal(result);
                                    i++;
                                }

                            }
                            catch (FormatException ex)
                            {
                                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                textBox1.Text = null;
                                textBox2.Text = null;
                                textBox3.Text = null;
                                textBox4.Text = null;
                                textBox7.Text = null;
                            }
                            break;
                        #endregion
                        case 5:
                            #region CNY CONVERSION

                            try
                            {//CAD
                                userInput = Convert.ToDouble(textBox1.Text);
                                result = (userInput * 0.18);
                                textBox2.Text = result.ToString("0.00");
                                user[j] = Convert.ToDecimal(userInput);
                                anumbers[i] = Convert.ToDecimal(result);
                                i++;

                                //USD
                                userInput = Convert.ToDouble(textBox1.Text);
                                result = (userInput * 0.14);
                                textBox5.Text = result.ToString("0.00");
                                user[j] = Convert.ToDecimal(userInput);
                                anumbers[i] = Convert.ToDecimal(result);
                                i++;

                                //Euros
                                userInput = Convert.ToDouble(textBox1.Text);
                                result = (userInput * 0.1246);
                                textBox3.Text = result.ToString("0.00");
                                user[j] = Convert.ToDecimal(userInput);
                                anumbers[i] = Convert.ToDecimal(result);
                                i++;

                                //Gbp
                                userInput = Convert.ToDouble(textBox1.Text);
                                result = (userInput * 0.1068);
                                textBox6.Text = result.ToString("0.00");
                                user[j] = Convert.ToDecimal(userInput);
                                anumbers[i] = Convert.ToDecimal(result);
                                i++;

                                //Roubles
                                userInput = Convert.ToDouble(textBox1.Text);
                                result = (userInput * 12.6354);
                                textBox4.Text = result.ToString("0.00");
                                user[j] = Convert.ToDecimal(userInput);
                                anumbers[i] = Convert.ToDecimal(result);
                                i++;

                                //Yen
                                userInput = Convert.ToDouble(textBox1.Text);
                                textBox7.Text = userInput.ToString("0.00"); 
                                anumbers[i] = Convert.ToDecimal(userInput);
                                i++;
                            }
                            catch (FormatException ex)
                            {
                                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                textBox1.Text = null;
                                textBox2.Text = null;
                                textBox3.Text = null;
                                textBox4.Text = null;
                                textBox5.Text = null;
                                textBox6.Text = null;
                                textBox7.Text = null;
                            }
                            break;
                            #endregion

                    }
                }

               

             
            }
            catch
            {
                MessageBox.Show("Invalid Numeral", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = null;
                textBox2.Text = null;
                textBox3.Text = null;
                textBox4.Text = null;
                textBox5.Text = null;
                textBox6.Text = null;
                textBox7.Text = null;
            }

           


        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        double value = 0;
        double value1 = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                value = Convert.ToDouble(textBox1.Text);
                value1 = Convert.ToDouble(textBox2.Text);

                if (textBox1.Text.Trim() == "0")
                {
                    //button2.Enabled = false;
                    MessageBox.Show("Not Allowed to press button till 1st button is pressed.", "ReadMeTextFile", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (textBox1.Text != null)
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
                        textIn.Write("\n" + DateTime.Now.ToShortDateString() + "     " + DateTime.Now.ToLongTimeString() + "\n");



                        string line = "";
                        string line2 = "";
                        string line3 = "";
                        string line4 = "";
                        string line5 = "";
                        string line6 = "";
                        string line7 = "";
                        int i = 0;
                        int j = 0;
                        string country = "";

                        if (radioButton1.Checked)
                        {
                            country = " CAD";
                        }
                        else if (radioButton2.Checked)
                        {
                            country = " USD";
                        }
                        else if (radioButton3.Checked)
                        {
                            country = " EUR";
                        }
                        else if (radioButton4.Checked)
                        {
                            country = " GBP";
                        }
                        else if (radioButton5.Checked)
                        {
                            country = " CNY";
                        }
                        else
                        {
                            country = " ROUB";
                        }

                        line7 = user[j] + country + "=";
                        line = "CAD " + anumbers[i].ToString("0.00") + "; ";
                        i++;
                        line2 = "USD " + anumbers[i].ToString("0.00") + "; ";
                        i++;
                        line3 = "EUR " + anumbers[i].ToString("0.00") + "; ";
                        i++;
                        line4 = "GBP " + anumbers[i].ToString("0.00") + "; ";
                        i++;
                        line5 = "CNY " + anumbers[i].ToString("0.00") + "; ";
                        i++;
                        line6 = "ROU " + anumbers[i].ToString("0.00");
                        i++;


                        textIn.Write(line7 + line + line2 + line3 + line4 + line5 + line6);






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
                        string textToPrint = "\t\t\tMoneyConversions \n\n";
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
                MessageBox.Show("Not Allowed to press button till 1st button is pressed.", "ReadMeTextFile", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = null;
                textBox2.Text = null;
                textBox3.Text = null;
                textBox4.Text = null;
                textBox5.Text = null;
                textBox6.Text = null;
                textBox7.Text = null;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Money_Exchange_Load(object sender, EventArgs e)
        {

        }
    }
}

