using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;
using Servicios;

namespace TPC_Ferrante_Gonzalez
{
    public partial class usuarioModPasswd : System.Web.UI.Page
    {
        public Usuario usuario;
        public Usuario usuarioQuery;
        public bool passValida;
        public string strVal;
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["Id"]);
            //usuario = new Usuario();

            //listo Tipo de Usuario
            List<TipoUsuario> auxTipoUSuario = new List<TipoUsuario>();
            NegTipoUsuario usuariosAListar = new NegTipoUsuario();

            if (!Page.IsPostBack)
            {
                try
                {

                    ValidarUsuario(id);

                    //auxTipoUSuario: carga de todos los servicios.
                    auxTipoUSuario = usuariosAListar.listar();


                }
                catch (Exception ex)
                {

                }
                finally
                {
                    Session.Add("usuarioAModificar", usuario);
                }
            }
        }

        public Usuario ValidarUsuario(int id)
        {
            usuarioQuery = (Usuario)Session["Usuario"];

            if (usuarioQuery.Id == id) usuario = usuarioQuery;

            return usuario;
        }

        protected void btnEnviarUsuario_Click(object sender, EventArgs e)
        {
            Page.Validate();

            if (!Page.IsValid)
                return;

                NegUsuario usuarioAModificar = new NegUsuario();
                usuario = (Usuario)Session["usuarioAModificar"];

                usuario.Password = txtPasswrd.Text;

                Session.Add("usuarioAModificar", usuario);

                try
                {
                    usuarioAModificar.modificar(usuario);
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    EmailService emailService = new EmailService();
                    emailService.armarCorreo(usuario.Mail.ToString(), "Cambio en su Usuario", "Se ha modificado satisfactoriamente su contraseña", "Usuario modificado: " + usuario.UserName);
                    try
                    {
                        emailService.enviarMail();
                    }
                    catch (Exception ex)
                    {

                    }
                    finally
                    {
                        Response.Redirect("Usuarios.aspx");
                    }
                }
            
        }
    }
}