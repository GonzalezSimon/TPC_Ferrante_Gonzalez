using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class NegocioTicket
    {
        public List<Ticket> listar(string consulta = "")
        {
            List<Ticket> lista = new List<Ticket>();

            AccesoDatos datos = new AccesoDatos();

            try
            {//, FechaCierre
                datos.setearConsulta("select IDTicket, NombreGrupoSoporte, Descripcion, Solucion, FechaApertura, EstadoTicket, t.Estado EstadoT, T.IDUsuario IDUsuario, u.Usuario Usuario, u.UPassword UPassword, U.Apellido Apellido, U.Nombre Nombre, U.Telefono Telefono, U.Mail Mail, L.IDLocalidad IDLocalidad, L.Nombre NombreL, L.Estado EstadoL, P.IDPais IDPais, P.Nombre NombreP, P.Estado EstadoP from Tickets T, Usuarios U, Localidades L, Paises P where U.IDUsuario = T.IDUsuario and L.IDLocalidad = U.IDLocalidad and P.IDPais = L.IDPais " + consulta);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Ticket aux = new Ticket();

                    aux.Id = (long)datos.Lector["IDTicket"];
                    aux.GrupoSoporte = (string)datos.Lector["NombreGrupoSoporte"];
                    //carga usuario
                    aux.Usuario.Id = (long)datos.Lector["IDUsuario"];
                    aux.Usuario.UserName = (string)datos.Lector["Usuario"];
                    aux.Usuario.Password = (string)datos.Lector["UPassword"];
                    aux.Usuario.Apellido = (string)datos.Lector["Apellido"];
                    aux.Usuario.Nombre = (string)datos.Lector["Nombre"];
                    aux.Usuario.Telefono = (string)datos.Lector["Telefono"];
                    aux.Usuario.Mail = (string)datos.Lector["Mail"];
                    //carga usuario.localidad
                    aux.Usuario.Localidad.Id = (long)datos.Lector["IDLocalidad"];
                    aux.Usuario.Localidad.Nombre = (string)datos.Lector["NombreL"];
                    aux.Usuario.Localidad.Estado = (bool)datos.Lector["EstadoL"];
                    //carga usuario.localida.pais
                    aux.Usuario.Localidad.Pais.Id = (int)datos.Lector["IDPais"];
                    aux.Usuario.Localidad.Pais.Nombre = (string)datos.Lector["NombreP"];
                    aux.Usuario.Localidad.Pais.Estado = (bool)datos.Lector["EstadoP"];


                    aux.FechaApertura = (DateTime)datos.Lector["FechaApertura"];
                   // aux.FechaCierre = (DateTime)datos.Lector["FechaCierre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Solucion = (string)datos.Lector["Solucion"];
                    aux.EstadoTicket = (string)datos.Lector["EstadoTicket"];
                    aux.Estado = (bool)datos.Lector["EstadoT"];

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

        public void agregar(Ticket nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {

                datos.setearConsulta("insert into Ticket (IDTicket, NombreGrupoSoporte, Descripcion, IDUsuario, FechaApertura, FechaCierre, EstadoTicket, Solucion, Estado)" +
                " VALUES (@IDTicket, @GrupoSoporte, @Descripcion, @FechaInicio, @FechaFin, @IDUsuario, @EstadoTicket, @Solucion, @Estado)");

                datos.agregarParametro("@IDTicketo", nuevo.Id);
                datos.agregarParametro("@GrupoSoporte", nuevo.GrupoSoporte);
                datos.agregarParametro("@Descripcion", nuevo.Descripcion);
                datos.agregarParametro("@FechaInicio", nuevo.FechaApertura);
                datos.agregarParametro("@FechaFin", nuevo.FechaCierre);
                datos.agregarParametro("@IDUsuario", nuevo.Usuario.Id);
                datos.agregarParametro("@EstadoTicket", nuevo.EstadoTicket);
                datos.agregarParametro("@Solucion", nuevo.Solucion);
                datos.agregarParametro("@EstadoTicket", nuevo.Estado);

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

        public void modificar(Ticket modificar)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta(
                "update Ticket set IDTicketo = @IDTicketo, NombreGrupoSoporte = @GrupoSoporte, IDUsuario = @IDUsuario," +
                " FechaApertura = @FechaInicio, FechaCierre = @FechaFin , Descripcion = @Descripcion, EstadoTicket = @EstadoTicket," +
                " Solucion = @Solucion, Estado = @Estado WHERE id =" + modificar.Id);

                datos.agregarParametro("@IDTicketo", modificar.Id);
                datos.agregarParametro("@GrupoSoporte", modificar.GrupoSoporte);
                datos.agregarParametro("@Descripcion", modificar.Descripcion);
                datos.agregarParametro("@FechaInicio", modificar.FechaApertura);
                datos.agregarParametro("@FechaFin", modificar.FechaCierre);
                datos.agregarParametro("@IDUsuario", modificar.Usuario.Id);
                datos.agregarParametro("@EstadoTicket", modificar.EstadoTicket);
                datos.agregarParametro("@Solucion", modificar.Solucion);
                datos.agregarParametro("@EstadoTicket", modificar.Estado);

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
                Ticket aux = new Ticket();

                aux.Id = ID;
                aux.Estado = false;

                datos.setearConsulta(
                    "update Ticket set Estado = 0 where ID = " + aux.Id);

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
