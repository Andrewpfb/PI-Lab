using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HttpHandler.App_Code
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
            string parmA = request.Params[0];
            string parmB = request.Params[1];
            response.Write("POST HTTP GAA: ParmA = " + parmA + " ParmB = " + parmB);
        }
    }
}