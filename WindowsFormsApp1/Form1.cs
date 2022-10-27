using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public int najpr;
        public int prob = 0;
        public int los = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.ForeColor = System.Drawing.Color.Black;
            label3.BackColor = System.Drawing.Color.White;
            button2.Enabled = true;
            prob = 0;
            label4.Text = Convert.ToString(prob);
            Random rand = new Random();
            if (radioButton1.Checked)
            {
                los = rand.Next(1, 1000);
                label1.Text = Convert.ToString(los);
            }
            else if (radioButton2.Checked)
            {

                los = rand.Next(1, 100);
                label1.Text = Convert.ToString(los);
            }
            else if (radioButton3.Checked)
            {
                los = rand.Next(1, 10);
                label1.Text = Convert.ToString(los);
            }

            Button1.Enabled = false;

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int proba = 0;
            try
            {
                proba = Convert.ToInt32(textBox7.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd " + ex.Message);
                textBox7.Clear();
            }

            prob++;
            if (proba == los)
            {
                label2.ForeColor = System.Drawing.Color.Green;
                label2.Text = "dobrze";
                label4.Text = Convert.ToString(prob);
                if (najpr == 0)
                {
                    najpr = prob;
                    label3.BackColor = System.Drawing.Color.Yellow;
                }
                else if (najpr >= prob)
                {
                    najpr = prob;

                    label3.BackColor = System.Drawing.Color.Yellow;

                }
                label3.Text = Convert.ToString(najpr);
                Button1.Enabled = true;
                button2.Enabled = false;
            }
            else if (proba != los)
            {
                label2.Text = "zle";
                label4.Text = Convert.ToString(prob);
            }

            if (checkBox1.Checked)
            {
                if (proba > los)
                {
                    label2.Text = "ZA DUŻO";
                }
                else if (proba < los)
                {
                    label2.Text = "ZA MAŁO";
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
