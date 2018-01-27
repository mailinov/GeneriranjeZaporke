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

namespace GeneriranjeZaporke
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            generiraj();
        }

        private void generiraj()
            
        {
            int m = Convert.ToInt32(numericUpDown1.Value);
            textBox1.Text = Class1.GeneratePassword(checkBox1.Checked,
                    checkBox2.Checked, checkBox3.Checked, m);           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            StreamWriter File = new StreamWriter("test.txt");
            File.Write(textBox1.Text);
            File.Close();
        }
        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }
        
    }
}
