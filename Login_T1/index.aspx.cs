using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Login_T1
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(tbEmail.Text=="joaquim@gmail.com" &&
                tbPassword.Text == "12345")
            {
                Session["nome"] = "joaquim";
                Session["perfil"] = "admin";
                Response.Redirect("segura.aspx");
            }
            lbErro.Text = "O login falhou.Tente novamente.";
        }
    }
}