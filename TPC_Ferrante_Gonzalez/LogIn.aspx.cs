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
    public partial class LogIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public Usuario InicioSecion(string user,string password)
        {
            NegUsuario n_usuario = new NegUsuario();
            List<Usuario> lista = new List<Usuario>();
            Usuario usu = new Usuario();
            lista = n_usuario.listar();
            foreach(Usuario item in lista)
            {
                if(item.UserName== user&& item.Password == password)
                {
                    usu = item;
                }
            }

            return usu;
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            string user = txtUsuario.Text;
            string Pass = txtPass.Text;
            Usuario cliente = new Usuario();

            cliente = InicioSecion(user, Pass);
            if (cliente.Nombre == null)
            {
                Response.Write("<script> alert("+"'Los datos son incorretos'"+") </script>");
            }
            else
            {
                Session["Usuario"] = cliente;
                //Response.Write("<script> alert(" + "'Usuario encontrado'" + ") </script>");
                Response.Redirect("Usuarios.aspx");

            }
        }

        protected void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}