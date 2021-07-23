using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;
using Servicios;
using System.Globalization;

namespace TPC_Ferrante_Gonzalez
{
    public partial class ModSuscripcion : Page
    {
        public ServicioContratado servicio;
        public ServicioContratado backServ;
        public ServicioContratado elServ;

        List<Servicio> listaServicios = new List<Servicio>();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["Id"]);


            //listo servicios
            List<Servicio> aux = new List<Servicio>();
            NegocioServicio serviciosAListar = new NegocioServicio();

            //listo ServciosContratados
            List<ServicioContratado> auxSus = new List<ServicioContratado>();
            NegocioServContratado suscripcionesAListar = new NegocioServContratado();

            //listo Usuarios
            List<Usuario> auxUsers = new List<Usuario>();
            NegUsuario usuariosAListar = new NegUsuario();

            //listo Delegado1
            List<Usuario> auxDelUno = new List<Usuario>();
            NegUsuario delUnoAListar = new NegUsuario();

            //listo Delegado2
            List<Usuario> auxDelDos = new List<Usuario>();
            NegUsuario delDosAListar = new NegUsuario();

            if (!IsPostBack) {
                try
                {
                    //valida el serivcio seleccionado y devuevle objeto: servicio (Suscripción)
                    ValidarSuscripcion(id);

                    //aux: carga de todos los servicios.
                    aux = serviciosAListar.listar();

                    //auxSus: carga de todos los servicios contratados
                    auxSus = suscripcionesAListar.listar();

                    //auxUsers: carga de todos los usuarios
                    auxUsers = usuariosAListar.listar();

                    //auxUsers: carga de todos los del1
                    auxDelUno = delUnoAListar.listar();

                    //auxUsers: carga de todos los del2
                    auxDelDos = delDosAListar.listar();

                    //carga de DDL Desripcion de Servicios
                    lstModSub.DataSource = aux;
                    lstModSub.DataTextField = "Descripcion";
                    lstModSub.DataValueField = "Id";
                    lstModSub.DataBind();

                    //carga de alias de todos las suscripciones
                    /*
                    lstModAlias.DataSource = auxSus;
                    lstModAlias.DataTextField = "GrupoSoporte";
                    lstModAlias.DataValueField = "Id";
                    lstModAlias.DataBind();


                    //modulo de ddl si se quiere implementar en Alias
                    <asp:DropDownList ID="lstModAlias" class="btn btn-secondary dropdown-toggle" runat="server" placeholder="Elija su subscripcion..." Style="width: auto; max-width: 100%; margin-left:3vh;">
                                    <asp:ListItem></asp:ListItem>
                                    </asp:DropDownList>*/

                    //carga de Username de todos sus usuarios
                    lstModUsuario.DataSource = auxUsers;
                    lstModUsuario.DataTextField = "UserName";
                    lstModUsuario.DataValueField = "Id";
                    lstModUsuario.DataBind();

                    //carga de Delegado 1 de todos sus usuarios
                    lstModDelUno.DataSource = auxDelUno;
                    lstModDelUno.DataTextField = "UserName";
                    lstModDelUno.DataValueField = "Id";
                    lstModDelUno.DataBind();

                    //carga de Delegado 2 de todos sus usuarios
                    lstModDelDos.DataSource = auxDelDos;
                    lstModDelDos.DataTextField = "UserName";
                    lstModDelDos.DataValueField = "Id";
                    lstModDelDos.DataBind();

                    //Carga de la descripción del servicio actual (usando objeto servicio)
                    lblDescripcionActual.Text = servicio.Servicio.Descripcion.ToString();
                    //Carga del Alias del servicio actual;
                    lblAlias.Text = servicio.GrupoSoporte.ToString();
                    //Carga Usuario del servicio actual;
                    lblUsuario.Text = servicio.Usuario.UserName.ToString();
                    //Carga estado del servicio
                    switch (servicio.Estado)
                    {
                        case true:
                                lblEstado.Text = "En vigencia";
                            break;
                        case false:                        
                                lblEstado.Text = "Vencido";
                            break;
                        default:
                            lblEstado.Text = "En vigencia";
                            break;
                    }
                    
                    cbxEstado.Checked = servicio.Estado;

                    if (servicio.Delegado1.UserName != null)
                    {
                        //Carga Delegado 1 del servicio actual;
                        lblDelUno.Text = servicio.Delegado1.UserName.ToString();
                        //Carga Delegado 1 del servicio actual;
                        lblDelDos.Text = servicio.Delegado2.UserName.ToString();
                    }
                    //Carga de Fecha Inicio de la suscripción actual
                    lblFechaInicio.Text = servicio.FechaCompra.Date.ToString();
                    //Carga de Fecha Inicio de la suscripción actual
                    lblFechaFin.Text = servicio.FechaCancelacion.Date.ToString();

                    /*if(lblDelUno.Text == string.Empty)
                    {
                        lblDelUno.Text = "Sin delegado supervisor.";
                    }
                    if (lblDelDos.Text == string.Empty)
                    {
                        lblDelDos.Text = "Sin delegado supervisor.";
                    }*/

                    foreach (Servicio item in aux)
                    {
                        listaServicios.Add(item);
                    }
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    Session.Add("ServicioAModificar", servicio);
                }
            }
        }

        public ServicioContratado ValidarSuscripcion(int id)
        {
            List<ServicioContratado> listado = (List<ServicioContratado>)Session["listadoServiciosContratadosAdm"];
            servicio = listado.Find(x => x.Id == id);

            return servicio;
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            NegocioServContratado servicioAModificar = new NegocioServContratado();

        

                servicio = (ServicioContratado)Session["ServicioAModificar"];
                backServ = (ServicioContratado)Session["ServicioAModificar"];
                elServ = (ServicioContratado)Session["ServicioAModificar"];

                servicio.Servicio.Id = ((uint)lstModSub.SelectedIndex + 1);
                servicio.Usuario.Id = ((uint)lstModUsuario.SelectedIndex + 1);
                servicio.Delegado1.Id = ((uint)lstModDelUno.SelectedIndex + 1);
                servicio.Delegado2.Id = ((uint)lstModDelDos.SelectedIndex + 1);
                servicio.FechaCompra = dateInicio.SelectedDate;
                servicio.FechaCancelacion = dateFin.SelectedDate;
                servicio.GrupoSoporte = txtAlias.Text;
                servicio.Estado = cbxEstado.Checked;

            elServ = backServ + elServ;

            
                Session.Add("ServicioAModificar", elServ);

                try
                {
                    servicioAModificar.modificar(elServ);
                }
                catch (Exception ex)
                {

                }
                finally
                    {
                        EmailService emailService = new EmailService();
                        emailService.armarCorreo(servicio.Usuario.Mail.ToString(), "Cambio en su servicio", "Se han aplicado los cambios en su servicio", "Suscripción modificada.");
                    try
                    {
                    emailService.enviarMail();
                    }
                    catch (Exception ex)
                    {

                    }
                    finally
                    {
                        Response.Redirect("ABMSuscripciones.aspx");
                    }
                }
        }
    }
}