using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Validation
{
    public partial class AAA : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Error_Handler(object sender, ServerValidateEventArgs args)
        {
            int arg = int.Parse(args.Value);
            bool isSimple = true;
            for (int i = 2; i <= arg / 2; i++)
            {
                if (arg % i == 0)
                {
                    isSimple = false;
                    break;
                }
            }
            args.IsValid = isSimple ? true : false;
        }
    }
}