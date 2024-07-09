using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Irelia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(100); //researched in chatgpt
            if (randomNumber < 50)
            {
                MessageBox.Show("The answer is yes");
            }
            else
            {
                MessageBox.Show("The answer is no");
            }
        }

        private void BTNcalm_CheckedChanged(object sender, EventArgs e)
        {
            Image calm = Image.FromFile("calm.jpeg");
            pictureBox4.Image = calm;
            
        }

        private void BTNanxious_CheckedChanged(object sender, EventArgs e)
        {
            Image anxious = Image.FromFile("anxious.jpeg");
            pictureBox3.Image = anxious;
        }

        private void BTNsad_CheckedChanged(object sender, EventArgs e)
        {
            Image sad = Image.FromFile("sad.jpeg");
            pictureBox1.Image = sad;
        }

        private void BTNhappy_CheckedChanged(object sender, EventArgs e)
        {
            Image happy = Image.FromFile("happy.jpeg");
            pictureBox2.Image = happy;
        }
    }
}
