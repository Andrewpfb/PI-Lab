﻿using System;

namespace Cache
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text += DateTime.Now.ToString() + "<br />";
        }
    }
}