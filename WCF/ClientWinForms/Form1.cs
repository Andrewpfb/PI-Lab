using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientWinForms
{
    public partial class Form1 : Form
    {
        ServiceReference1.Service1Client client;

        public Form1()
        {
            InitializeComponent();
            client = new ServiceReference1.Service1Client();
            client.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(client.Addition(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox6.Text = Convert.ToString(client.Subtraction(Convert.ToDouble(textBox4.Text), Convert.ToDouble(textBox5.Text)));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox9.Text = client.Concat(textBox7.Text, textBox8.Text);
        }
    }
}
