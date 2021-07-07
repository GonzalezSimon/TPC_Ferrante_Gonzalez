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
    public partial class Tickets : System.Web.UI.Page
    {
        public NegocioTicket tickets = new NegocioTicket();
        //public Ticket ticket;
        public Ticket ticketSeleccionado;
        public List<Ticket> ListaTickets;
        public Usuario usuario;
        public NegUsuario loggeado = new NegUsuario();


        protected void Page_Load(object sender, EventArgs e)
        {
            ticketSeleccionado = (Ticket)Session["ticketSeleccionado"];

            usuario = new Usuario();

            if (!Page.IsPostBack)
            {
                ValidarSesion();

                usuario = (Usuario)Session["Usuario"];//loggeado.listar("and IDUsuario = 1")[0];

                try
                {
                    ListaTickets = tickets.listar("and IDTicket = 1");


                    Session.Add("ticketSeleccionado", ticketSeleccionado);
                    Session.Add("tickets", ListaTickets);
                }
                catch (Exception ex)
                {
                    Session.Add("Error", ex.ToString());
                    Response.Redirect("Error.aspx");
                }
            }
        }

        protected void btnSolucionar_Click(object sender, EventArgs e)
        {

            ticketSeleccionado = new Ticket();

            ticketSeleccionado = (Ticket)Session["TicketSol"];

            //txtSolucion.Text = ticketSeleccionado.Solucion;

            //cketSeleccionado = ListaTickets.Find(x => x.Id.ToString() == ticketSeleccionado.Id.ToString());
            ticketSeleccionado.Solucion = txtSolucion.Text;
            ticketSeleccionado.FechaCierre = DateTime.Now;

            tickets.modificar(ticketSeleccionado);

         
            Session.Add("tickets", ListaTickets);
            Session.Add("TicketSol", ticketSeleccionado);

            Response.Redirect("Tickets.aspx");


        }

        protected void TicketGrid_SelectedIndexChanged1(object sender, EventArgs e)
        {
            ticketSeleccionado = new Ticket();

            //var var = TicketGrid.SelectedRow.Cells[7].Text;

            ticketSeleccionado.Id = Convert.ToInt32(TicketGrid.SelectedRow.Cells[0].Text);
            ticketSeleccionado.GrupoSoporte = TicketGrid.SelectedRow.Cells[1].Text;
            ticketSeleccionado.Usuario.Id = Convert.ToInt32(TicketGrid.SelectedRow.Cells[2].Text);
            ticketSeleccionado.FechaApertura = Convert.ToDateTime(TicketGrid.SelectedRow.Cells[3].Text);
            ticketSeleccionado.FechaCierre = Convert.ToDateTime(TicketGrid.SelectedRow.Cells[4].Text);
            ticketSeleccionado.Descripcion = TicketGrid.SelectedRow.Cells[5].Text;
            ticketSeleccionado.Solucion = TicketGrid.SelectedRow.Cells[6].Text;
            ticketSeleccionado.EstadoTicket = TicketGrid.SelectedRow.Cells[7].Text;
            ticketSeleccionado.Estado = Convert.ToBoolean(TicketGrid.SelectedRow.Cells[8].Text.ToString());

            txtSolucion.Text = ticketSeleccionado.Solucion;

            Session.Add("TicketSol", ticketSeleccionado);
        }

        private void ValidarSesion()
        {
            Usuario aux = new Usuario();
            try
            {
                aux = (Usuario)Session["Usuario"];
            }
            catch (Exception)
            {

            }
            if (Session["Usuario"] == null || !(aux.Tipo.Nombre.Equals("A")))
            {
                Response.Redirect("Home.aspx");
            }
        }

    }

}