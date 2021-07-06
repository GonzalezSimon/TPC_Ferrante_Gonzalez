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
    public partial class Usuarios : System.Web.UI.Page
    {
        public NegUsuario loggeado = new NegUsuario();
        public Usuario usuario;

        public List<ServicioContratado> list = new List<ServicioContratado>();
        protected void Page_Load(object sender, EventArgs e)
        {
            usuario = new Usuario();
            List<ServicioContratado> aux = new List<ServicioContratado>();

            //usuario = loggeado.listar("and IDUsuario = 2")[0];
            if (!Page.IsPostBack)
            {
                ValidarSesion();

                usuario = (Usuario)Session["Usuario"];
                NegocioServContratado servicioContratado = new NegocioServContratado();
                aux = servicioContratado.listar();

                foreach (ServicioContratado item in aux)
                {
                    if (item.Usuario.Id == usuario.Id)
                    {
                        list.Add(item);
                    }
                }

                try
                {
                    Session.Add("listadoServiciosContratados", list);
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
            if (Session["Usuario"] == null)
            {
                Response.Redirect("Home.aspx");
            }
        }
    }
}