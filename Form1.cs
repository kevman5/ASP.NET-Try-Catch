using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace aspnet_TryCatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /// create checks for math formula you can't break using try-catch-finally
            /// horsepower = force(in lbs) * distance(in feet) / by time(in minutes)
            int hp, force, dist, time;
            try { 
            force = int.Parse(textBox1.Text);
            dist = int.Parse(textBox2.Text);
            time = int.Parse(textBox3.Text);
            hp = (force * dist) / time;
            tb_ans.Text = hp.ToString();
                if (hp < 1)
                {
                    tb_ans.Text = "Horsepower was less than 1";
                }
            }
            catch (DivideByZeroException ex)
            {
                tb_ans.Text = "Cannot Divide by Zero";
            }
            catch (FormatException ex)
            {
                tb_ans.Text = "Must enter only numbers!";
            }
            catch (OverflowException ex)
            {
                tb_ans.Text = "Value is too large";
            }
            finally
            {
                string message = "Horsepower Calculated";
                MessageBox.Show(message);
            }

        }

        private void SocialCheck_Click(object sender, EventArgs e)
        {
            ///<SocialCheck>
           
            string pattern1 = @"\d{3}-\d{2}-\d{4}";
            
                string inputStr = textBox4.Text;
                bool isMatched = Regex.IsMatch(inputStr, pattern1);

                if (isMatched == true)
                {
                    textBox5.Text = "Correct Format";
                }
                else
                {
                    textBox5.Text = "Incorrect Social";
                }
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
