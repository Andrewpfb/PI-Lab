using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        ServiceReference1.WebService1SoapClient client;
        public Form1()
        {
            InitializeComponent();
            client = new ServiceReference1.WebService1SoapClient();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           textBox11.Text = client.Sum(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)).ToString("D");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox12.Text= client.Sub(Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text)).ToString("D");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox13.Text = client.Mul(Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text)).ToString("D");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            client.SetZ(Convert.ToInt32(textBox7.Text));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox8.Text = client.GetZ().ToString("D");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox10.Text = client.AddZ(Convert.ToInt32(textBox9.Text)).ToString("D");
        }
    }
}
