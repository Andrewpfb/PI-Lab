using System;
using System.Web.UI.WebControls;

namespace Validation
{
    public partial class BBB : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HiddenDate.Text = DateTime.Now.Date.ToString();
        }

        protected void Check_Pass(object sender, ServerValidateEventArgs args)
        {
            string testString = args.Value.ToString();
            bool isDuplicate = false;
            if (testString.Length < 7)
            {
                args.IsValid = false;
            }
            else
            {
                for (int i = 0; i < testString.Length; i++)
                {
                    for (int y = i + 1; y < testString.Length; y++)
                    {
                        if (testString[i] == testString[y])
                        {
                            isDuplicate = true;
                            break;
                        }
                    }
                }
                args.IsValid = isDuplicate ? false : true;
            }
        }
    }
}