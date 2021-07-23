using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;
using System.Globalization;
using MercadoPago.Config;
using MercadoPago.Client.Common;
using MercadoPago.Client.Preference;

namespace TPC_Ferrante_Gonzalez
{
    public partial class ResumenServicio : System.Web.UI.Page
    {
        public Servicio servicioAContratar;
        public Usuario loggeado;


        protected void Page_Load(object sender, EventArgs e)
        {
            MercadoPagoConfig.AccessToken = "TEST-8650963571641233-072207-e6dd2a055dafe385439a88bb5fb66266-532051842";


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

            /*var request = new PreferenceRequest
            {
                Items = new List<PreferenceItemRequest>
            {
            new PreferenceItemRequest
            {
            Title = servicioAContratar.Descripcion.ToString(),
            Quantity = 1,
            CurrencyId = "ARS",
            UnitPrice =  Convert.ToDecimal(servicioAContratar.Precio.ToString()),
                    },
                },
            };


            // Crea la preferencia usando el client
            var client = new PreferenceClient();
            PreferenceClient preference = await client.CreateAsync(request);
            */
        }

        public Servicio ValidarServicio(int id)
        {
            List<Servicio> listado = (List<Servicio>)Session["Servicios"];
            servicioAContratar = listado.Find(x => x.Id == id);

            return servicioAContratar;
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            if (loggeado.Nombre == null)
            {
                Response.Write("<script> alert(" + "'¡Debe de estar loggiado para acceder al servicio!'" + ") </script>");
            }
        }
    }
}