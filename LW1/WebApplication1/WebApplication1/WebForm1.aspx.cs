using System;
using System.Web;
using System.Web.UI;


namespace WebApplication1
{
    public partial class WebForm1 : Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            Label1.Text += " --INIT-- ";
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Label1.Text += " --FIRST LOAD-- ";
            }
            else
            {
                Label1.Text += " --POSTBACK LOAD-- ";
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text += " --CLICK-- ";
        }
        protected void Page_Prerender(object sender, EventArgs e)
        {
            Label1.Text += " --PRERENDER-- ";
        }
        protected void Page_Unload(object sender, EventArgs e)
        {
            Label1.Text += " --UNLOAD-- ";
        }
        protected void Page_Disposed(object sender, EventArgs e)
        {
            Label1.Text += " --DISPOSED-- ";
        }

        protected void Check_CheckedChanged(object sender, EventArgs e)
        {
            Label1.Text += " --CHECK-- ";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Write("<br> Machine's name: " + Environment.MachineName);
            Response.Write("<br> OS Version : " + Environment.OSVersion);
            Response.Write("<br> Memory: " + Environment.WorkingSet);
            Response.Write("<br> ASP.NET Version: " + Environment.Version.ToString());
            Response.Write("<br> IP-Adress: " + HttpContext.Current.Request.ServerVariables["LOCAL_ADDR"]);
            Response.Write("<br> Temporary Catalog: " + Environment.GetEnvironmentVariable("TEMP"));
            Response.Write("<br> Request: " + (Request.IsLocal ? "Local" : "Not local"));
            Response.Write("<br> Request: " + (Request.IsSecureConnection ? "Secure" : "Not secure"));
            Response.Write("<br> Browser: " + Request.Browser.Version);
            Response.Write("<br> Browser: " + Request.Browser.MinorVersion);
            Response.Write("<br> Browser: " + Request.Browser.MajorVersion);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            TextBox2.Text = "*" + TextBox2.Text + "*";
            String s = Request["__VIEWSTATE"];
            Label3.Text = "[" + s.Length + "] [" + TextBox2.Text.Length + "]";
        }
    }
}