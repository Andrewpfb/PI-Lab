using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Web_services
{
    /// <summary>
    /// Сводное описание для WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        [WebMethod (Description ="Sum", EnableSession =true)]
        public int Sum(int x, int y)
        {
            return x + y;
        }

        [WebMethod (Description ="Sub", EnableSession = true)]
        public int Sub(int x, int y)
        {
            return x - y;
        }

        [WebMethod (Description ="Mul", EnableSession = true)]
        public int Mul(int x, int y)
        {
            return x * y;
        }

        private int z = 0;

        [WebMethod(Description = "Set z", EnableSession = true)]
        public void SetZ(int z)
        {
            // Session["z"] = z;
            Application.Remove("z");
            Application.Add("z", z);
        }

        [WebMethod(Description = "Get z", EnableSession = true)]
        public int GetZ()
        {
            int rc = 0;
            //if (Session["z"] != null)
            //{
            //    rc = (int)Session["z"];
            //}
            if (Application.Get("z")!=null)
            {
                rc = (int)Application.Get("z");
            }
            return rc;
        }

        [WebMethod(Description = "Add z and return", EnableSession = true)]
        public int AddZ(int z)
        {
            int rc = 0;
            //if(Session["z"]!=null)
            //{
            //    rc = (int)Session["z"] + z;
            //}
            if (Application.Get("z") != null)
            {
                rc = (int)Application.Get("z")+z;
            }
            return rc;
        }
    }
}
