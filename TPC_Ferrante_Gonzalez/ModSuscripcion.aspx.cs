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
    public partial class ModSuscripcion : Page
    {
        public ServicioContratado mod = new ServicioContratado();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["Id"]);

            List<ServicioContratado> listado = (List<ServicioContratado>)Session["listadoServiciosContratadosAdm"];
            mod = listado.Find(x => x.Id == id);
        }
    }
}