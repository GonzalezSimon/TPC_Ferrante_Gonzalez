using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace TPC_Ferrante_Gonzalez
{
    public partial class ABMUsuarios : System.Web.UI.Page
    {

        public NegUsuario loggeado = new NegUsuario();
        public NegUsuario negUsuarioACambiar = new NegUsuario();
        public Usuario usuario;

        public List<Usuario> uList = new List<Usuario>();
        protected void Page_Load(object sender, EventArgs e)
        {

            usuario = new Usuario();

            List<Usuario> aux = new List<Usuario>();

            if (!Page.IsPostBack)
            {
                ValidarSesion();

                usuario = (Usuario)Session["Usuario"];

                try
                {

                    aux = negUsuarioACambiar.listar();

                    foreach (Usuario item in aux)
                    {

                        uList.Add(item);
                    }

                    Session.Add("listadoUsuarios", uList);

                }
                catch (Exception /*ex*/)
                {
                    /*Session.Add("Error", ex.ToString());
                    Response.Redirect("Error.aspx");*/
                }
            }
        }

        private void ValidarSesion()
        {
            Usuario aux = new Usuario();
            try
            {
                aux = (Usuario)Session["Usuario"];
            }
            catch (Exception)
            {

            }
            if (Session["Usuario"] == null || !(aux.Tipo.Nombre.Equals("A")))
            {
                Response.Redirect("Home.aspx");
            }

        }
    }
}