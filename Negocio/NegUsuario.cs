using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class NegUsuario
    {
        public class NegocioServicio
        {

            public List<Usuario> listar(bool combobox = false)
            {
                List<Usuario> lista = new List<Usuario>();

                AccesoDatos datos = new AccesoDatos();

                try
                {
                    datos.setearConsulta("select ID, Nombre, Estado from Usuarios");
                    datos.ejecutarLectura();

                    while (datos.Lector.Read())
                    {
                        Usuario aux = new Usuario();

                        aux.Id = (int)datos.Lector["ID"];
                        aux.UserName = (string)datos.Lector["Usuario"];
                        aux.Password = (string)datos.Lector["UPassword"];
                        aux.Apellido = (string)datos.Lector["Apellido"];
                        aux.Nombre = (string)datos.Lector["Nombre"];
                        aux.Telefono = (string)datos.Lector["Telefono"];
                        aux.Mail = (string)datos.Lector["Mail"];
                        aux.Localidad.Id = (int)datos.Lector["IDLocalidad"];
                        aux.Tipo.Id = (int)datos.Lector["IDTipoUsuario"];
                        aux.URLimagen = (string)datos.Lector["URLImagen"];
                        aux.FechaCreacion = (DateTime)datos.Lector["FechaCreacion"];
                        aux.Estado = (bool)datos.Lector["EstadoUsuario"];

                        lista.Add(aux);
                    }

                    return lista;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    datos.cerrarConexion();
                }

            }

            public void agregar(Usuario nuevo)
            {
                AccesoDatos datos = new AccesoDatos();
                try
                {

                    datos.setearConsulta("insert into Usuario (Usuario, UPassword, Apellido, Nombre, Telefono, Mail, IDLocalidad, IDTipoUsuario, URLUsuario, FechaCreacion, EstadoUsuario)" +
                    " VALUES (@Usuario, @UPassword, @Apellido, @Nombre, @Telefono, @Mail, @IDLocalidad, @IDTipoUsuario, @URLUsuario, @FechaCreacion,  @EstadoUsuario)");

                    datos.agregarParametro("@Usuario", nuevo.UserName);
                    datos.agregarParametro("@UPassword", nuevo.Password);
                    datos.agregarParametro("@Apellido", nuevo.Apellido);
                    datos.agregarParametro("@Nombre", nuevo.Nombre);
                    datos.agregarParametro("@Telefono", nuevo.Telefono);
                    datos.agregarParametro("@Mail", nuevo.Mail);
                    datos.agregarParametro("@IDLocalidad", nuevo.Localidad.Id);
                    datos.agregarParametro("@IDTipoUsuario", nuevo.Tipo.Id);
                    datos.agregarParametro("@URLUsuario", nuevo.URLimagen);
                    datos.agregarParametro("@FechaCreacion", nuevo.FechaCreacion);
                    datos.agregarParametro("@EstadoUsuario", nuevo.Estado);


                    datos.ejectutarAccion();

                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    datos.cerrarConexion();
                }
            }

            public void modificar(Usuario modificar)
            {
                AccesoDatos datos = new AccesoDatos();
                try
                {
                    datos.setearConsulta(
                    "update Usuarios set Usuario = @Usuario, UPassword = @UPassword, Apellido = @Apellido, Nombre = @Nombre, Telefono = @Telefono, Mail = @Mail, Telefono = @Telefono, IDLocalidad = @IDLocalidad, IDTipoUsuario = @IDTipoUsuario, URLUsuario = @URLUsuario, FechaCreacion = @FechaCreacion, EstadoUsuario = @EstadoUsuario WHERE id =" + modificar.Id);

                    datos.agregarParametro("@Usuario", modificar.UserName);
                    datos.agregarParametro("@UPassword", modificar.Password);
                    datos.agregarParametro("@Apellido", modificar.Apellido);
                    datos.agregarParametro("@Nombre", modificar.Nombre);
                    datos.agregarParametro("@Telefono", modificar.Telefono);
                    datos.agregarParametro("@Mail", modificar.Mail);
                    datos.agregarParametro("@IDLocalidad", modificar.Localidad.Id);
                    datos.agregarParametro("@IDTipoUsuario", modificar.Tipo.Id);
                    datos.agregarParametro("@URLUsuario", modificar.URLimagen);
                    datos.agregarParametro("@FechaCreacion", modificar.FechaCreacion);
                    datos.agregarParametro("@EstadoUsuario", modificar.Estado);


                    datos.ejectutarAccion();

                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    datos.cerrarConexion();
                }
            }

            public void eliminar(int ID)
            {
                AccesoDatos datos = new AccesoDatos();
                try
                {
                    Usuario aux = new Usuario();

                    aux.Id = ID;
                    aux.Estado = false;

                    datos.setearConsulta(
                        "update Usuarios set Estado = 0 where ID = " + aux.Id);

                    datos.ejectutarAccion();

                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    datos.cerrarConexion();
                }
            }
        }
    }
}

