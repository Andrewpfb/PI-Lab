using System;
using System.Text;
using System.Net;
using System.Collections.Specialized;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = "http://localhost:80/handlers/yyy.ndy";
            using (var webClient = new WebClient())
            {
                var parameters = new NameValueCollection();
                parameters.Add("a", "2");
                parameters.Add("b", "3");
                var response = webClient.UploadValues(url, parameters);
                textBox1.Text = Encoding.Default.GetString(response);
            }
        }
    }
}