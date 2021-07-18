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
            public List<Usuario> listar(string consulta = "")
            {
                List<Usuario> lista = new List<Usuario>();

                AccesoDatos datos = new AccesoDatos();

                try
                {
                datos.setearConsulta(
                    "select U.IDUsuario IDUsuario, Usuario, UPassword, Apellido, u.Nombre Nombre, Telefono, Mail, U.IDLocalidad IDLocalidad," +
                    " L.Nombre NombreL, L.Estado EstadoL, P.Nombre NombreP, P.IDPais IDPais, P.Estado EstadoP, U.IDTipoUsuario IDTipoUsuario," +
                    " TU.Estado EstadoT, TU.TipoUsuario TipoUsuario, URLUsuario, FechaCreacion, EstadoUsuario from Usuarios U, TipoUsuario TU," +
                    " Localidades L, Paises P where U.IDLocalidad = L.IDLocalidad and P.IDPais = L.IDPais and TU.IDTipoUsuario = U.IDTipoUsuario " + consulta);
                    datos.ejecutarLectura();


                while (datos.Lector.Read())
                    {
                        Usuario aux = new Usuario();

                        aux.Id = (long)datos.Lector["IDUsuario"];
                        aux.UserName = (string)datos.Lector["Usuario"];
                        aux.Password = (string)datos.Lector["UPassword"];
                        aux.Apellido = (string)datos.Lector["Apellido"];
                        aux.Nombre = (string)datos.Lector["Nombre"];
                        aux.Telefono = (string)datos.Lector["Telefono"];
                        aux.Mail = (string)datos.Lector["Mail"];
                        
                        //Carga de Localidad
                        aux.Localidad.Id = (long)datos.Lector["IDLocalidad"];
                        aux.Localidad.Nombre = (string)datos.Lector["NombreL"];
                        aux.Localidad.Estado = (bool)datos.Lector["EstadoL"];
                       
                        //Carga de Pais
                        aux.Localidad.Pais.Id = (int)datos.Lector["IDPais"];
                        aux.Localidad.Pais.Nombre = (string)datos.Lector["NombreP"];
                        aux.Localidad.Pais.Estado = (bool)datos.Lector["EstadoP"];

                        //Carga de tipo
                        aux.Tipo.Estado = (bool)datos.Lector["EstadoT"];
                        aux.Tipo.Nombre = (string)datos.Lector["TipoUsuario"];
                        aux.Tipo.Id = (int)datos.Lector["IDTipoUsuario"];

                        aux.URLimagen = (string)datos.Lector["URLUsuario"];
                        aux.FechaCreacion = (DateTime)datos.Lector["FechaCreacion"];
                        aux.Estado = (bool)datos.Lector["EstadoUsuario"];
                        
                    if(aux.Estado==true)
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

                    datos.setearConsulta("insert into Usuarios (Usuario, UPassword, Apellido, Nombre, Telefono, Mail, IDLocalidad, IDTipoUsuario, URLUsuario, FechaCreacion, EstadoUsuario)" +
                    " VALUES (@Usuario, @UPassword, @Apellido, @Nombre, @Telefono, @Mail, @IDLocalidad, @IDTipoUsuario, @URLUsuario, @FechaCreacion,  @EstadoUsuario)");

                    datos.agregarParametro("@Usuario", nuevo.UserName);
                    datos.agregarParametro("@UPassword", nuevo.Password);
                    datos.agregarParametro("@Apellido", nuevo.Apellido);
                    datos.agregarParametro("@Nombre", nuevo.Nombre);
                    datos.agregarParametro("@Telefono", nuevo.Telefono);
                    datos.agregarParametro("@Mail", nuevo.Mail);
                    datos.agregarParametro("@IDLocalidad", nuevo.Localidad.Id);
                    datos.agregarParametro("@IDTipoUsuario", "3");
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
                    "update Usuarios set Usuario = @Usuario, UPassword = @UPassword, Apellido = @Apellido, Nombre = @Nombre, Telefono = @Telefono, Mail = @Mail, IDLocalidad = @IDLocalidad, IDTipoUsuario = @IDTipoUsuario, URLUsuario = @URLUsuario, FechaCreacion = @FechaCreacion, EstadoUsuario = @EstadoUsuario WHERE IDUsuario =" + modificar.Id);

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
                        "update Usuarios set EstadoUsuario = 0 where IDUsuario = " + aux.Id);

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

