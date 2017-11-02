using System;

namespace lab_34
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Label2.Text = Label3.Text = Label4.Text = Label6.Text = Label7.Text = DateTime.Now.ToLongTimeString();

        }

        protected void Button1_Click(object sender, EventArgs e) { }

        protected void TextBox1_TextChanged(object sender, EventArgs e) { }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e) { }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e) { }

        protected void Button2_Click(object sender, EventArgs e)
        {
            throw new ApplicationException("ERROR");
        }

        protected void cmdRefreshTime_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(5000);
            Label8.Text = DateTime.Now.ToLongTimeString();
        }
    }
}