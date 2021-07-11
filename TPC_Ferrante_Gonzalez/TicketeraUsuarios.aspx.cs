using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;

namespace TPC_Ferrante_Gonzalez
{
    public partial class TicketeraUsuarios : System.Web.UI.Page
    {
        public List<ServicioContratado> list;
        protected void Page_Load(object sender, EventArgs e)
        {
            list = new List<ServicioContratado>();
            if (!Page.IsPostBack)
            {
                list = (List<ServicioContratado>)Session["listadoServiciosContratados"];
            }
        }
    }
}