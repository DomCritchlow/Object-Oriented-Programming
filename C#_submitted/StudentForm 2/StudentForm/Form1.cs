using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentForm
{
    public partial class The_Form : Form
    {


        public The_Form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string value = null;
            
            if (radioButton1.Checked == true)
            {
                 int value1 = (int.Parse(textBox3.Text) * 300);
                   value = value1.ToString();
            }
            if (radioButton2.Checked == true)
            {
                 int value2 = int.Parse(textBox3.Text) * 800;
                 value = value2.ToString();
                
            }

            this.Tuition_name.Text = value; 
        }
    }
}
