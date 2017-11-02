using System;

namespace Cache
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text += DateTime.Now.ToString() + "<br />";
        }
        private static string GetDateTime(System.Web.HttpContext httpContext)
        {
            return "<br>" + DateTime.Now.ToString();
        }
    }
}