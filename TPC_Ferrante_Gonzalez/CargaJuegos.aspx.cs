using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;

namespace TPC_Ferrante_Gonzalez
{
    public partial class CargaJuegos : System.Web.UI.Page
    {
        NegVideoJuegos n_juegos;
        VideoJuegos juego;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            juego = new VideoJuegos();
            n_juegos = new NegVideoJuegos();

            if (FileUpload1.HasFile)
            {
                juego.Id = 0;
                juego.Nombre = txtNombre.Text;
                juego.Empresa = txtEmpresa.Text;
                juego.Estado = true;
                juego.Imagen = GuardarImagen(FileUpload1, txtNombre.Text);

                n_juegos.agregar(juego);
            }
        }
        protected string GuardarImagen(FileUpload aux,string Nombre)
        {
            if (aux.HasFile)
            {
                //si hay una archivo.
                string nombreArchivo = Nombre;
                string ruta = "~/ImgJuegos/" + nombreArchivo+".png";
                aux.SaveAs(Server.MapPath(ruta));
                return ruta;
             }
            return "";
        }
    }
}