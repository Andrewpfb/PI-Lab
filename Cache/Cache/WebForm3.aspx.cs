using System;


//тестируем в opera/edge/chrome и firefox. Адрес - http://localhost/cache/WebForm3.aspx
//Выведет разную инфу в зависимости от браузера. Есть подозрение, что опера эдж и хром на одном движке, 
//потому что асп.нет определяет их как браузер хром


namespace Cache
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text += DateTime.Now.ToString() + "<br />" + Request.Browser.Browser;
        }
    }
}