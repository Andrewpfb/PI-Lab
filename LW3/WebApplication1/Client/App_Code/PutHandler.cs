using System.Web;

namespace WebApplication1.App_Code
{
    public class PutHandler : IHttpHandler
    {
        public bool IsReusable
        {
            get { return false; }
        }

        public void ProcessRequest(HttpContext context)
        {
            HttpRequest request = context.Request;
            HttpResponse response = context.Response;
            response.Write("PutHandler" + "AAA - " + request.Params[0] + " BBB - " + request.Params[1]);
        }
    }
}