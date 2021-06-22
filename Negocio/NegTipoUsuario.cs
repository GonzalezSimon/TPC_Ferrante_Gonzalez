using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegTipoUsuario
    {
        public List<TipoUsuario> listar(bool combobox = false)
        {
            List<TipoUsuario> lista = new List<TipoUsuario>();

            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select IDTipoUsuario, TipoUsuario, Estado from TipoUsuario");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    TipoUsuario aux = new TipoUsuario();

                    aux.Id = (int)datos.Lector["IDTipoUsuario"];
                    aux.Nombre = (string)datos.Lector["TipoUsuario"];
                    aux.Estado = (bool)datos.Lector["Estado"];

                    if (aux.Estado != false)
                    {
                        lista.Add(aux);
                    }
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

        public void agregar(TipoUsuario nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into TipoUsuario (IDTipoUsuario, TipoUsuario, Estado)" +
                " VALUES (@IDTipoUsuario, @Nombre, @Estado)");

                datos.agregarParametro("@IDTipoUsuario", nuevo.Id);
                datos.agregarParametro("@Nombre", nuevo.Nombre);
                datos.agregarParametro("@Estado", nuevo.Estado);

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

        public void modificar(TipoUsuario modificar)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta(
                    "update TipoUsuario set TipoUsuario = @Nombre, Estado = @Estado where id = " + modificar.Id);

                datos.agregarParametro("@IDTipoServicio", modificar.Id);
                datos.agregarParametro("@Nombre", modificar.Nombre);
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
                TipoUsuario aux = new TipoUsuario();

                aux.Id = ID;
                aux.Estado = false;

                datos.setearConsulta(
                    "update TipoUsuario set Estado = 0 where ID = " + aux.Id);

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
