using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace calorieCalculatorProgram
{
    
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            double tb1, tb2, tb3;
            double.TryParse(textBox1.Text, out tb1);
            double.TryParse(textBox2.Text, out tb2);
            double.TryParse(textBox3.Text, out tb3);
            
            if (((Regex.IsMatch(textBox1.Text, @"^\d+$"))&& (Regex.IsMatch(textBox2.Text, @"^\d+$"))&&(Regex.IsMatch(textBox3.Text, @"^\d+$"))) ==true)
            {
                if (checkBox1.Checked && !checkBox2.Checked)
                {
                    double men = 66 + (6.2 * tb1) + (12.7 * tb2) - (6.67 * tb3);
                    MessageBox.Show("you are burnning " + men + " everyday without exercize");

                }
                else if (checkBox2.Checked && !checkBox1.Checked)
                {
                    double women = 655.1 + (4.35 * tb1) + (4.7 * tb2) - (4.7 * tb3);
                    MessageBox.Show("you are burnning " + women + " everyday without exercize");
                }
                else if (checkBox1.Checked && checkBox2.Checked)
                {
                    MessageBox.Show("pls choose only men or women ");
                }
                else
                {
                    MessageBox.Show("pls choose gender");
                }
            }
            else if (((Regex.IsMatch(textBox1.Text, @"^\d+$")) && (Regex.IsMatch(textBox2.Text, @"^\d+$")) && (Regex.IsMatch(textBox3.Text, @"^\d+$"))) == false)

            { 
                MessageBox.Show("you can only put numbers");
            }
            else
            {
                MessageBox.Show("pls insert the data");
            }
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fm1 = new Form1();
            fm1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            if ((checkBox1.Checked && checkBox2.Checked)==true)
            {
                checkBox1.Checked = !checkBox1.Checked;
                checkBox2.Checked = !checkBox2.Checked;
            }
            else
            {
                checkBox1.Checked = !checkBox1.Checked;
                checkBox2.Checked = !checkBox2.Checked;
            }

        }
    }
}
