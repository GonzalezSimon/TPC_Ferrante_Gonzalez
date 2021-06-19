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
        public List<Ticket> listar(bool combobox = false)
        {
            List<Ticket> lista = new List<Ticket>();

            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select Id, GrupoSoporte, IDUsuario, FechaInicio, FechaFin, Descripcion, Estado from Tickets");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Ticket aux = new Ticket();

                    aux.Id = (int)datos.Lector["ID"];
                    aux.GrupoSoporte = (string)datos.Lector["GrupoSoporte"];
                    aux.Usuario.Id = (int)datos.Lector["IDUsuario"];
                    aux.FechaApertura = (DateTime)datos.Lector["FechaInicio"];
                    aux.FechaCierre = (DateTime)datos.Lector["FechaFin"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Estado = (bool)datos.Lector["Estado"];

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

                datos.setearConsulta("insert into Ticket (IDTicket, GrupoSoporte, IDUsuario, FechaFin, FechaInicio, Descripcion, Estado)" +
                " VALUES (@IDTicket, @GrupoSoporte, @IDUsuario, @FechaInicio, @FechaFin, @Descripcion, @Estado)");

                datos.agregarParametro("@IDTicketo", nuevo.Id);
                datos.agregarParametro("@GrupoSoporte", nuevo.GrupoSoporte);
                datos.agregarParametro("@IDUsuario", nuevo.Usuario.Id);
                datos.agregarParametro("@FechaInicio", nuevo.FechaApertura);
                datos.agregarParametro("@FechaFin", nuevo.FechaCierre);
                datos.agregarParametro("@Descripcion", nuevo.Descripcion);
                datos.agregarParametro("@Estado", nuevo.Estado);

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
                "update Ticket set IDTicketo = @IDTicketo, GrupoSoporte = @GrupoSoporte, IDUsuario = @IDUsuario, FechaInicio = @FechaInicio, FechaFin = @FechaFin , Descripcion = @Descripcion, Estado = @Estado WHERE id =" + modificar.Id);

                datos.agregarParametro("@IDTicketo", modificar.Id);
                datos.agregarParametro("@GrupoSoporte", modificar.GrupoSoporte);
                datos.agregarParametro("@IDUsuario", modificar.Usuario.Id);
                datos.agregarParametro("@FechaInicio", modificar.FechaApertura);
                datos.agregarParametro("@FechaFin", modificar.FechaCierre);
                datos.agregarParametro("@Descripcion", modificar.Descripcion);
                datos.agregarParametro("@Estado", modificar.Estado);

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
