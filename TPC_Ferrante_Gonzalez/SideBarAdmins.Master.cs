using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPC_Ferrante_Gonzalez
{
    public partial class SideBarAdmins : MasterPage
    {
        public Usuario user = null;
        public string tpUsuario = "";
        public string NivelUsuario = "";
        public string Img = "";
        public string Nombre = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            user = new Usuario();
            if (Session["Usuario"] != null)
            {
                user = (Usuario)Session["Usuario"];
                Img = user.URLimagen;
                Nombre = user.Nombre;
            }
            if (Session["NivelAcceso"] != null)
            {
                tpUsuario = Session["NivelAcceso"].ToString();
                switch (tpUsuario)
                {
                    case "A":
                        NivelUsuario = "Administrador";
                        break;
                    case "C":
                        NivelUsuario = "Usuario";
                        break;
                    default:
                        NivelUsuario = "Sin Definir";
                        break;
                }

            }


        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (Session["Usuario"] == null)
            {
                Response.Redirect("LogIn.aspx");

            }


        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session["Usuario"] = null;
            Response.Redirect("Home.aspx");

        }
    }
}