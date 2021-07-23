using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;
using System.Globalization;

namespace TPC_Ferrante_Gonzalez
{
    public partial class ResumenServicio : System.Web.UI.Page
    {
        public Servicio servicioAContratar;
        public Usuario loggeado;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                int id = int.Parse(Request.QueryString["Id"]);
                //Nuevo servicio
                servicioAContratar = new Servicio();

                ValidarServicio(id);

                lblDescripcion.Text = servicioAContratar.Descripcion;
                imgJuego.ImageUrl = servicioAContratar.URLServicio;//ACA ES CUANDO LA COMPOSICION ES DIOS: servicioAContratar.IDJuego.URLImagen.....
                lblSlots.Text = servicioAContratar.Slots.ToString();
                lblPrecio.Text = servicioAContratar.Precio.ToString("c", CultureInfo.GetCultureInfo("es-AR"));
            }

        }

        public Servicio ValidarServicio(int id)
        {
            List<Servicio> listado = (List<Servicio>)Session["Servicios"];
            servicioAContratar = listado.Find(x => x.Id == id);

            return servicioAContratar;
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            if (loggeado == null)
            {
                Response.Write("<script> alert(" + "'¡Debe de estar loggiado para acceder al servicio!'" + ") </script>");
            }
        }
    }
}