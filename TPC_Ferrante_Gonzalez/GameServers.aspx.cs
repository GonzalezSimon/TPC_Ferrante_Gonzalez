using System;
using Dominio;
using Negocio;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.IO;

namespace TPC_Ferrante_Gonzalez
{
    public partial class GameServers : System.Web.UI.Page
    {
        NegVideoJuegos n_juegos = new NegVideoJuegos();
        public VideoJuegos juegos = new VideoJuegos();
        public List<VideoJuegos> listjuegos = new List<VideoJuegos>();
        Dictionary<string, VideoJuegos> Listado = new Dictionary<string, VideoJuegos>();
        public string imgconv = "";
        string ruta = "~/ImgJuegos";
        protected void Page_Load(object sender, EventArgs e)
        {
            listjuegos=n_juegos.listar();
           // dlJuegos.DataSource = n_juegos.listar();
            //dlJuegos.DataBind();
            imgJuego.ImageUrl = listjuegos[0].Imagen;

        }

        protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            imgJuego.ImageUrl = "~/Img/7daystoday.jpg";
        }
    }
}