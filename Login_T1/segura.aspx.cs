using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Login_T1
{
    public partial class segura : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //verificar se o utilizador fez login
            if (Session["nome"] == null)
                Response.Redirect("index.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //terminar sessão
            Session.Clear();

            Response.Redirect("index.aspx");
        }
    }
}