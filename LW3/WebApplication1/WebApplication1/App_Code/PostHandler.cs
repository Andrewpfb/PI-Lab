using System;
using System.Web;

namespace WebApplication1.App_Code
{
    public class PostHandler : IHttpHandler
    {
        public bool IsReusable
        {
            get { return false; }
        }

        public void ProcessRequest(HttpContext context)
        {
            HttpRequest request = context.Request;
            HttpResponse response = context.Response;
            int result = Convert.ToInt32(request.Params[0]) + Convert.ToInt32(request.Params[1]);
            response.Write(result);
        }
    }
}