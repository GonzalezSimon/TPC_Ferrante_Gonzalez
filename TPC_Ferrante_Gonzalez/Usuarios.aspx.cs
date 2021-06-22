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

        public List<ServicioContratado> list;
        protected void Page_Load(object sender, EventArgs e)
        {
            usuario = new Usuario();
            
            usuario = loggeado.listar("and IDUsuario = 2")[0];


            NegocioServContratado servicioContratado = new NegocioServContratado();

            try
            {
                list = servicioContratado.listar();

                Session.Add("listadoServiciosContratados", list);
            }
            catch(Exception ex)
            {
                Session.Add("Error", ex.ToString());
                Response.Redirect("Error.aspx");
            }


        }
    }
}