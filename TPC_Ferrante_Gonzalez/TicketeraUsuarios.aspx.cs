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
        public List<Servicio> list;
        public List<ServicioContratado> aux;
        public Servicios serv = new Servicios();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                list = new List<Servicio>();
                aux = new List<ServicioContratado>();
                aux = (List<ServicioContratado>)Session["listadoServiciosContratados"];
                foreach (var item in aux)
                {
                    list.Add(item.Servicio);
                }
                lstSubs.DataSource = list;
                lstSubs.DataTextField = "Descripcion";
                lstSubs.DataValueField = "Id";
                lstSubs.DataBind();
            }
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {

        }

        protected void lstSubs_SelectedIndexChanged(object sender, EventArgs e)

        {
            aux = (List<ServicioContratado>)Session["listadoServiciosContratados"];
            long auxd = long.Parse(lstSubs.SelectedItem.Value);
            ServicioContratado aux2 = new ServicioContratado();
            foreach (var item in aux)
            {
                if (item.Id == auxd)
                {
                    aux2 = item;
                    
                }
            }
           
            lblAlias.Text = aux2.GrupoSoporte;
        }
    }
}