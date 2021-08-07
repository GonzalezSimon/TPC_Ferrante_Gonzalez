using Dominio;
using Negocio;
using Servicios;
using System;
using System.Net;
using System.IO;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using System.Configuration;

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

            if (IsReCaptchaValid())
            {

                Page.Validate();

                if (!Page.IsValid)
                    return;

                int idLoc = int.Parse(dwlLocalidad.SelectedItem.Value);

                user.Apellido = txtApellido.Text;
                user.Nombre = txtNombre.Text;
                user.Estado = true;
                user.Localidad = listAux.Find(x => x.Id == idLoc);
                user.FechaCreacion = DateTime.Now;
                user.Mail = txtMail.Text;
                user.Password = txtPass.Text;
                user.Telefono = txtTelefono.Text;
                user.URLimagen = GuardarImagen(fuImagenUsuario, user.Nombre + "_" + user.Apellido);
                user.UserName = txtNombUsuario.Text;

                try
                {
                    n_usuario.agregar(user);
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    EmailService emailService = new EmailService();
                    emailService.armarCorreo(user.Mail.ToString(), "Creacion de cuenta", "Se ha creado satisfactoriamente su cuenta", "Usuario creado: " + user.UserName);
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

                    Response.Redirect("Login.aspx");
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

        public bool IsReCaptchaValid()
        {
            var result = false;
            var catchaResponse = Request.Form["g-recaptcha-response"];
            var secretKey = ConfigurationManager.AppSettings["SecretKey"];
            var apiUrl = "https://www.google.com/repatcha/api/siteverify?secret={0}&response={1}";
            var requestUri = string.Format(apiUrl, secretKey, catchaResponse);
            var request = (HttpWebRequest)WebRequest.Create(requestUri);

            using(WebResponse response = request.GetResponse())
            {
                using (StreamReader stream = new StreamReader(response.GetResponseStream()))
                {
                    Newtonsoft.Json.Linq.JObject jResponse = Newtonsoft.Json.Linq.JObject.Parse(stream.ReadToEnd());
                    var isSuccess = jResponse.Value<bool>("Success");
                    result = (isSuccess) ? true : false;
                }
            }
            return result;
        }
    }
}