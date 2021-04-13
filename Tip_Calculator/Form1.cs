using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tip_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private static int i, j;

        private void button5_Click(object sender, EventArgs e)
        {
            double bill, tip, people, t1, t2;
            char c = '%';
            textBox2.Text = textBox2.Text.Replace(c.ToString(), String.Empty);
            bill = Convert.ToDouble(textBox1.Text);
            tip = Convert.ToDouble(textBox2.Text);
            people = Convert.ToDouble(textBox3.Text);
            if (tip < 0 || people <= 0 || bill <= 0)
            {
                string message = "Please enter a Valid Input";
                string title = "Invalid Input!";
                MessageBox.Show(message, title);
                string msg = "Do you want to abort this operation?";
                string tt = "Close Window";
                MessageBoxButtons buttons = MessageBoxButtons.AbortRetryIgnore;
                DialogResult result = MessageBox.Show(msg, tt, buttons, MessageBoxIcon.Warning);
                if (result == DialogResult.Abort)
                {
                    this.Close();
                }
                else if (result == DialogResult.Retry)
                {
                    Form1 NewForm = new Form1();
                    NewForm.Show();
                    this.Dispose(false);
                }
            }
            t1 = (bill / people) * tip / 100;
            t2 = (bill / people) + t1;
            t1 = Math.Round(t1, 2);
            t2 = Math.Round(t2, 2);
            textBox2.Text = tip.ToString() + "%";
            textBox4.Text = "$" + t1.ToString();
            textBox5.Text = "$" + t2.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i--;
            textBox2.Text = i.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            i++;
            textBox2.Text = i.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            j--;
            textBox3.Text = j.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            j++;
            textBox3.Text = j.ToString();
        }
    }
}
