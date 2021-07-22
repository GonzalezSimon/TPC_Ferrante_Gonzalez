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
    public partial class Servicios : System.Web.UI.Page
    {
        public List<Servicio> serv = new List<Servicio>();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}