using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Loop
{
    public partial class frmLoop : Form
    {
        public frmLoop()
        {
            InitializeComponent();
        }

        private void btnForLoop_Click(object sender, EventArgs e)
        {
            for (int c = 1; c <= 81; c += 1)
            {
                txtDisplay.Text += c.ToString() + Environment.NewLine;
            }
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            int c = 0;
            do
            {
                txtDisplay.Text += c.ToString() + Environment.NewLine;
                c += 100;
            } while (c <= 1000);
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            int c = 1;
            while (c <= 5)
            {
                txtDisplay.Text += c.ToString() + Environment.NewLine;
                c += 1;
            }
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            string strPass = "cit100";
            string strUser = Interaction.InputBox("Please enter your password.");
            int c = 1;
            while ((strUser != strPass))
            {
                if (c < 3)
                {
                    strUser = Interaction.InputBox("Wrong password. Try again.");
                    c += 1;
                }
                else
                {
                    MessageBox.Show("You've tried 3 times already. You are locked Out.");
                    return;
                }
            }
            MessageBox.Show("You are now logged in.");
        }

        private void btnTables_Click(object sender, EventArgs e)
        {
            //for (int c = 1; c <= 100; c++)
            //{
            //    txtDisplay.Text += "100 +" + c.ToString() + " = " +
            //        (100 + c).ToString() + Environment.NewLine;
            //}
            //for (int x = 0; x <= 32; x++)
            //{
            //    txtDisplay.Text += "2 ^ " + x.ToString() + " = " +
            //        (Math.Pow(2, x)).ToString() + Environment.NewLine;
            //}
            //for (int c = 1; c <= 99; c++)
            //{
            //    txtDisplay.Text += "99 *" + c.ToString() + " = " +
            //        (99 * c).ToString() + Environment.NewLine;
            //}
            //for (int c = 1; c <= 99; c += 1)
            //{
            //    txtDisplay.Text += "99 * " + c.ToString() + " = " +
            //        (99 * c).ToString() + Environment.NewLine;

            //}
            for (int c = 1; c <= 9 ; c += 1)
            {
                txtDisplay.Text += c.ToString() + " ^ 2 = " +
                    (c * c).ToString() + Environment.NewLine;
            }
        }

        private void btnThreeTimes_Click(object sender, EventArgs e)
        {
            int n = 1;
            while (n <= 100000)
            {
                txtDisplay.Text += n.ToString() + Environment.NewLine;
                n = n * 3;
            }
            //double x = 1000;
            //int c = 1;
            //while (c <= 20)
            //{
            //    txtDisplay.Text += (x).ToString() + Environment.NewLine;
            //    x /= 2;
            //    c++;
            //}
        }

        private void btnCLear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = " ";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPractice_Click(object sender, EventArgs e)
        {
            //    for (int c = 1; c <= 101; c++)
            //    {
            //        txtDisplay.Text += c.ToString() + " * " +
            //            (c - 1).ToString() + " = " +
            //            (c * (c - 1)).ToString() + Environment.NewLine;
            //    }
            //    for (int c = 10; c <= 100; c++)
            //    {
            //        txtDisplay.Text += c.ToString() + " * 2 = " +
            //            (c * 2).ToString() + Environment.NewLine;
            //    }
            //for (int c = 10; c >= 0; c--)
            //{
            //    txtDisplay.Text += c.ToString() + Environment.NewLine;
            //    txtDisplay.Text += "you are number " + c.ToString() +
            //        " good programmer" + Environment.NewLine;
            //}
            for (decimal c = 11; c <= 555; c = c + 3)
            {
                //txtDisplay.Text += c.ToString("n2") + Environment.NewLine;
                txtDisplay.Text += "You are number " + c.ToString() +
                    " good programmer" + Environment.NewLine;
            }
        }

        private void btnMagic_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int MagicNumber = r.Next(1, 101);
            int totalTrial = 1;
            int intGuess = 0;
            string strGuess = null;
            txtDisplay.Text = "Game Rule: A magic number between 1 and 100 have been genrated." +
                Constants.vbNewLine + "Try to guess it in as few times as possible.";

            do
            {
                do
                {
                    strGuess = Interaction.InputBox("What is the magic number?");
                } while (!(int.TryParse(strGuess, out intGuess)));

                if (intGuess > MagicNumber)
                {
                    txtDisplay.Text = totalTrial.ToString() + " trial: " + intGuess.ToString() +
                        " is larger than the magic number." + Environment.NewLine + txtDisplay.Text;
                }
                else if (intGuess < MagicNumber)
                {
                    txtDisplay.Text = totalTrial.ToString() + " trial: " +
                        intGuess.ToString() + " is smaller than the magic number." +
                        Environment.NewLine + txtDisplay.Text;
                }
                totalTrial += 1;
            } while (intGuess != MagicNumber);
            txtDisplay.Text = intGuess.ToString() + " is the magic number. You have tried " +
                (totalTrial - 1).ToString() + " times" + Environment.NewLine + Environment.NewLine +
                txtDisplay.Text;   
            }
            }
    }



            
            
    

        
    


