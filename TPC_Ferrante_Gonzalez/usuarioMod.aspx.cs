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
    public partial class usuarioMod : System.Web.UI.Page
    {
        public Usuario usuario;
        public Usuario usuarioQuery;
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


                    //Carga de Nombre del usuario
                    lblNombre.Text = usuario.Nombre.ToString();

                    //Carga de Apellido del usuario
                    lblApellido.Text = usuario.Apellido.ToString();

                    //Carga de Telefono
                    lblTelefono.Text = usuario.Telefono.ToString();

                    //Carga de Email
                    lblMail.Text = usuario.Mail.ToString();

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
            if (rfvApe.IsValid && rfvNombre.IsValid && rfvMail.IsValid && rfvTel.IsValid)
            {
                
                NegUsuario usuarioAModificar = new NegUsuario();
                usuario = (Usuario)Session["usuarioAModificar"];

                usuario.Password = usuario.Password;
                usuario.Nombre = txtNombre.Text;
                usuario.Apellido = txtApellido.Text;
                usuario.Telefono = txtTelefono.Text;
                usuario.Mail = txtMail.Text;
                usuario.URLimagen = GuardarImagen(fuImagenUsuario, usuario.Nombre + "_" + usuario.Apellido);

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
                    emailService.armarCorreo(usuario.Mail.ToString(), "Cambio en su Usuario", "Se ha modificado satisfactoriamente su usuario", "Usuario modificado: " + usuario.UserName);
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
        protected string GuardarImagen(FileUpload aux, string NombreArchivo)
        {
            if (aux.HasFile)
            {
                string ruta = "/ImgUsuarios/" + NombreArchivo + ".png";
                aux.SaveAs(Server.MapPath(ruta));
                return ruta;
            }

            return "Sin Definir";
        }
    }
}