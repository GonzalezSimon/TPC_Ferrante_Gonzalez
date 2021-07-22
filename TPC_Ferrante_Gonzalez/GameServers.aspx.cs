﻿using System;
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
        NegocioServicio n_serv = new NegocioServicio();
        public VideoJuegos juegos = new VideoJuegos();
        public List<VideoJuegos> listjuegos = new List<VideoJuegos>();
        public List<Servicio> listServ = new List<Servicio>();
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                try
                {
                    listjuegos = n_juegos.listar();
                    listServ = n_serv.listar();
                    Session.Add("Juegos", listjuegos);
                    Session.Add("Servicios", listServ);
                }
                catch (Exception) { }

                dlJuego.DataSource = listjuegos;
                dlJuego.DataTextField = "Nombre";
                dlJuego.DataValueField = "Id";
                dlJuego.DataBind();
                OrdenaDrop(ref dlJuego);
                //OrdenaDrop(ref dlJuego);

                imgJuego.ImageUrl = "/Imgs/animacion.png";
            }

        }


        protected void OrdenaDrop(ref DropDownList ddl)
        {
            List<ListItem> listCopy = new List<ListItem>();
            foreach (ListItem item in ddl.Items)
                listCopy.Add(item);
            ddl.Items.Clear();
            foreach (ListItem item in listCopy.OrderBy(item => item.Text))
                ddl.Items.Add(item);

        }

        protected void dlJuego_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<VideoJuegos> aux = (List<VideoJuegos>)Session["Juegos"];
            int idjue = 0;
           
            foreach (var item in aux)
            {
                if (item.Id == Convert.ToInt32(dlJuego.SelectedValue))
                {
                    imgJuego.ImageUrl = item.Imagen;
                    idjue = item.Id;
                }
            }
            dlServicio.DataSource = CargaServ(idjue);
            dlServicio.DataTextField = "Descripcion";
            dlServicio.DataValueField = "Id";
            dlServicio.DataBind();
        }
        protected List<Servicio> CargaServ(int id)
        {
            List<Servicio> aux = (List<Servicio>)Session["Servicios"];
            List<Servicio> listado = new List<Servicio>();
            foreach (var item in aux)
            {
                if (item.IdJuego == id)
                {
                    listado.Add(item);
                }
            }
            return listado;
        }
    }
}