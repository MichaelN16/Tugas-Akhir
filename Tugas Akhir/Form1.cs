using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace $safeprojectname$
{
    public partial class Form1 : Form
    {
        double bill = 0;
        double apple = 10000;
        double lemon = 20000;
        double banana = 3000;
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Mr.")
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
                // Form1 Form2=new Form1();
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                checkBox2.Checked = true;
                checkBox3.Checked = true;
                checkBox4.Checked = true;
            }
            if (checkBox5.Checked == false)
            {
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
            }
            if (checkBox2.Checked == false || checkBox3.Checked == false || checkBox4.Checked == false)
            {
                checkBox5.Checked = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true && checkBox3.Checked == false && checkBox4.Checked == false)
            {
                bill = banana;
            }
            else if (checkBox2.Checked == true && checkBox3.Checked == true)
            {
                bill = banana + apple;
            }
            else if (checkBox2.Checked == true && checkBox4.Checked == true)
            {
                bill = banana + lemon;
            }
            else if (checkBox3.Checked == true && checkBox4.Checked == false)
            {
                bill = apple;
            }
            else if (checkBox3.Checked == true && checkBox4.Checked == true)
            {
                bill = apple + lemon;
            }
            else if (checkBox4.Checked == true)
            {
                bill = lemon;
            }
            textBox2.Text = "Total Bill is: Rp." + Convert.ToString(bill) + ". Thank You! " + comboBox1.Text + " " + textBox3.Text + ". Your Agent name is : " + comboBox2.Text + " from : " + comboBox4.Text;


            MessageBox.Show(string.Format("{0}", this.textBox2.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "Succesfully added!!";
        }
        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
            comboBox1.Text = String.Empty;
            comboBox4.Text = String.Empty;
            comboBox2.Text = String.Empty;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }
    }
}
