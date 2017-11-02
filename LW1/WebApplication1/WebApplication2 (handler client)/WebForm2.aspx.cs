﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.IO;

namespace WebApplication2__handler_client_
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GetBtn_Click(object sender, EventArgs e)
        {
                HttpWebRequest rq = (HttpWebRequest)HttpWebRequest.Create("http://DESKTOP-9G91L11:8078/WebForm2.ndy");
                rq.Method = "GET";
                HttpWebResponse rs = (HttpWebResponse)rq.GetResponse();
                StreamReader rdr = new StreamReader(rs.GetResponseStream());
                Response.Write(rdr.ReadToEnd());
        }

        protected void PostBtn_Click(object sender, EventArgs e)
        {
            HttpWebRequest rq = (HttpWebRequest)HttpWebRequest.Create("http://DESKTOP-9G91L11:8078/vvv.ndy");
            rq.Method = "POST";
            rq.MaximumResponseHeadersLength = 100;
            rq.ContentLength = 0;
            HttpWebResponse rs = (HttpWebResponse)rq.GetResponse();
            StreamReader rdr = new StreamReader(rs.GetResponseStream());
            Response.Write(rdr.ReadToEnd());
        }

        protected void PutBtn_Click(object sender, EventArgs e)
        {
            HttpWebRequest rq = (HttpWebRequest)HttpWebRequest.Create("http://DESKTOP-9G91L11:8078/vvv.ndy");
            rq.Method = "PUT";
            HttpWebResponse rs = (HttpWebResponse)rq.GetResponse();
            StreamReader rdr = new StreamReader(rs.GetResponseStream());
            Response.Write(rdr.ReadToEnd());
        }
    }
}