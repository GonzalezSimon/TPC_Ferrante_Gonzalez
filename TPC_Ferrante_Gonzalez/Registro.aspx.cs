using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace TPC_Ferrante_Gonzalez
{
    public partial class Registro : System.Web.UI.Page
    {
        Usuario user;
        NegUsuario n_usuario;
        NegocioLocalidad n_localidad;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            n_localidad = new NegocioLocalidad();
            if (!Page.IsPostBack)
            {
                dwlLocalidad.DataSource = n_localidad.listar();
                dwlLocalidad.DataTextField = "Nombre";
                dwlLocalidad.DataValueField = "Id";
                dwlLocalidad.DataBind();
                Session.Add("Localidades", n_localidad.listar());
            }
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            user = new Usuario();
            n_usuario = new NegUsuario();
            List<Localidad> listAux = (List<Localidad>)Session["Localidades"];
            

            int idLoc= int.Parse(dwlLocalidad.SelectedItem.Value);

            user.Apellido = txtApellido.Text;
            user.Nombre = txtNombre.Text;
            user.Estado = true;
            user.Localidad = listAux.Find(x=>x.Id==idLoc);
            user.FechaCreacion = DateTime.Now;
            user.Mail = txtMail.Text;
            user.Password = txtPass.Text;
            user.Telefono = txtTelefono.Text;
            user.URLimagen = GuardarImagen(fuImagenUsuario,user.Nombre+"_"+user.Apellido);
            user.UserName = txtNombUsuario.Text;

            n_usuario.agregar(user);

            Response.Redirect("Login.aspx");

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