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
    public partial class ABMSuscripciones : System.Web.UI.Page
    {
        public NegocioServContratado Suscripcion = new NegocioServContratado();
        //public Ticket ticket;
        public ServicioContratado servicioSeleccionado;
        public List<ServicioContratado> ListaSuscripciones;
        public Usuario usuario;
       // public NegUsuario loggeado = new NegUsuario();


        protected void Page_Load(object sender, EventArgs e)
        {
            servicioSeleccionado = (ServicioContratado)Session["servicioSeleccionado"];

            usuario = new Usuario();

            if (!Page.IsPostBack)
            {
                ValidarSesion();

                usuario = (Usuario)Session["Usuario"];//loggeado.listar("and IDUsuario = 1")[0];

                try
                {
                    //ListaTickets = tickets.listar("and IDTicket = 1");


                    Session.Add("servicioSeleccionado", servicioSeleccionado);
                    Session.Add("listSuscripciones", ListaSuscripciones);
                }
                catch (Exception ex)
                {
                    Session.Add("Error", ex.ToString());
                    Response.Redirect("Error.aspx");
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
