﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GroceriesWebApp.Users
{
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void logout_Click(object sender, EventArgs e)
        {
            if (Session["user_id"] != null)
            {
                Session.Abandon();
                Session.Clear();
                Response.Redirect("login.aspx");
            }
        }
    }
}