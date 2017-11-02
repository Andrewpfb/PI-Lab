using System;


namespace WebApplication1
{
    public partial class Default : System.Web.UI.Page
    {
        ServiceReference1.WebService1SoapClient client;
        protected void Page_Init(object sender, EventArgs e)
        {
            client = new ServiceReference1.WebService1SoapClient();
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            client.SetZ(Convert.ToInt32(TextBox1.Text));
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox2.Text = client.GetZ().ToString("D");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            TextBox4.Text = client.AddZ(Convert.ToInt32(TextBox3.Text)).ToString("D");
        }
    }
}