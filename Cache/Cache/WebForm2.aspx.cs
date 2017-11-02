using System;

//Демонстрация. Сначала выполняем запрос с любым параметром, потом меняем его на новый (время новое будет), потом
//возвращаем старое значение параметра - и время станет старым.
//a=1&b=1&c=3. Изменение a,b влечет изменение времени, изменение с ни на что не влияет

namespace Cache
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text += DateTime.Now.ToString() + "<br />";
        }
    }
}