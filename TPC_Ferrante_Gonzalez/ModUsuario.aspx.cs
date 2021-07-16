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
    public partial class ModUsuario : System.Web.UI.Page
    {
        public Usuario usuario;
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


                    //carga de Tipos de Usuario de todos sus usuarios
                    lstModTipoUsuario.DataSource = auxTipoUSuario;
                    lstModTipoUsuario.DataTextField = "Nombre";
                    lstModTipoUsuario.DataValueField = "Id";
                    lstModTipoUsuario.DataBind();


                    //Carga de Nombre de Usuario
                    lblUsernName.Text = usuario.UserName.ToString();

                    //Carga de Nombre del usuario
                    lblNombre.Text = usuario.Nombre.ToString();

                    //Carga de Apellido del usuario
                    lblApellido.Text = usuario.Apellido.ToString();

                    //Carga de Contraseña
                    lblPassword.Text = usuario.Password.ToString();

                    //Carga de Telefono
                    lblTelefono.Text = usuario.Telefono.ToString();

                    //Carga de Email
                    lblMail.Text = usuario.Mail.ToString();

                    //Carga de Localidad
                    lblLocalidad.Text = usuario.Localidad.Nombre.ToString();

                    //Carga de tipo de usuario
                    if (usuario.Tipo.Nombre.ToString() == "A")
                    {
                        lblTipoUsuario.Text = "Administrador";
                    }
                    else if(usuario.Tipo.Nombre.ToString() == "C")
                    {
                        lblTipoUsuario.Text = "Cliente";
                    }
                    else if(usuario.Tipo.Nombre.ToString() == "S")
                    {
                        lblTipoUsuario.Text = "Supervisor";
                    }
                }
                catch(Exception ex)
                {

                }
                finally
                {

                }
            }
        }

        public Usuario ValidarUsuario(int id)
        {
            List<Usuario> listado = (List<Usuario>)Session["listadoUsuarios"];
            usuario = listado.Find(x => x.Id == id);

            return usuario;
        }
    }
}