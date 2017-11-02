using System;
using System.Net;
using System.IO;
using System.Text;

namespace Client
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GetButton_Click(object sender, EventArgs e)
        {
            try
            {
                HttpWebRequest rq = (HttpWebRequest)WebRequest.Create("http://localhost:80/handlers/yyy.ndy?A=4&B=2");
                rq.Method = "GET";
                HttpWebResponse rs = (HttpWebResponse)rq.GetResponse();
                StreamReader rdr = new StreamReader(rs.GetResponseStream());
                Response.Write(rdr.ReadToEnd());
            }
            catch (WebException we)
            {
                Response.Write(we.Status);
                Response.Write("<br />" + " Message: " + we.Message);
                Response.Write("<br />" + " Target Site: " + we.TargetSite);
                Response.Write("<br />" + " Source: " + we.Source);
            }
        }

        protected void PostButton_Click(object sender, EventArgs e)
        {
            HttpWebRequest rq = (HttpWebRequest)WebRequest.Create("http://localhost:80/handlers/yyy.ndy");
            rq.Method = "POST";
            rq.MaximumResponseHeadersLength = 100;
            var postData = "a=4";
            postData += "&b=2";
            var data = Encoding.ASCII.GetBytes(postData);
            rq.ContentType = "application/x-www-form-urlencoded";
            rq.ContentLength = data.Length;
            using (var stream = rq.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }
            HttpWebResponse rs = (HttpWebResponse)rq.GetResponse();
            StreamReader rdr = new StreamReader(rs.GetResponseStream());
            Response.Write(rdr.ReadToEnd());
        }

        protected void OptionsButton_Click(object sender, EventArgs e)
        {
            HttpWebRequest rq = (HttpWebRequest)WebRequest.Create("http://localhost:80/handlers/yyy.ndy");
            rq.Method = "OPTIONS";
            rq.MaximumResponseHeadersLength = 100;
            var postData = "a=4";
            postData += "&b=2";
            var data = Encoding.ASCII.GetBytes(postData);
            rq.ContentType = "application/x-www-form-urlencoded";
            rq.ContentLength = data.Length;
            using (var stream = rq.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }
            HttpWebResponse rs = (HttpWebResponse)rq.GetResponse();
            StreamReader rdr = new StreamReader(rs.GetResponseStream());
            Response.Write(rdr.ReadToEnd());
        }

        protected void PutButton_Click(object sender, EventArgs e)
        {
            HttpWebRequest rq = (HttpWebRequest)WebRequest.Create("http://localhost:80/handlers/yyy.ndy");
            rq.Method = "PUT";
            rq.MaximumResponseHeadersLength = 100;
            var postData = "a=4";
            postData += "&b=2";
            var data = Encoding.ASCII.GetBytes(postData);
            rq.ContentType = "application/x-www-form-urlencoded";
            rq.ContentLength = data.Length;
            using (var stream = rq.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }
            HttpWebResponse rs = (HttpWebResponse)rq.GetResponse();
            StreamReader rdr = new StreamReader(rs.GetResponseStream());
            Response.Write(Response.StatusCode.ToString());
        }
    }
}