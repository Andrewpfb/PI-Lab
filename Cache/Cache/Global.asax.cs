using System;
using System.Web;

namespace Cache
{
    public class Global : HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
        }

        public override string GetVaryByCustomString(HttpContext context, string custom)
        {
            if (custom.Equals("browser"))
            {
                string browserName;
                browserName = Context.Request.Browser.Browser;
                browserName += Context.Request.Browser.MajorVersion;
                return browserName;
            }
            else
            {
                return base.GetVaryByCustomString(context, custom);
            }
        }
    }
}