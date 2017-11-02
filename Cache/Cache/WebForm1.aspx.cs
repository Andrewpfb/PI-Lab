using System;


//Демонстрация. Сначала выполняем запрос с любым параметром, потом меняем его на новый (время новое будет), потом
//возвращаем старое значение параметра - и время станет старым.


namespace Cache
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text += DateTime.Now.ToString() + "<br />";
        }
    }
}