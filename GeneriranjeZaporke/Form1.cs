using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneriranjeZaporke
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();   
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            generiraj();
        }

        private void generiraj()
        {
            if (checkBox1.Checked)
                textBox1.Text = Class1.GeneratePassword(2, 3, 0, 0);
            else if (checkBox2.Checked)
                textBox1.Text = Class1.GeneratePassword(0, 0, 5, 0);
            else if (checkBox3.Checked)
                textBox1.Text = Class1.GeneratePassword(0, 0, 0, 5);
            //textBox1.Text = "nesto";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
