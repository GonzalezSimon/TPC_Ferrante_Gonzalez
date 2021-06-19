using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegTipoServicio
    {
        public List<TipoServicio> listar(bool combobox = false)
        {
            List<TipoServicio> lista = new List<TipoServicio>();

            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select ID, Nombre, Estado from TiposServicios");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    TipoServicio aux = new TipoServicio();

                    aux.Id = (int)datos.Lector["ID"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
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

        public void agregar(TipoServicio nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into Servicios (IDTipoServicio, Nombre, Estado)" +
                " VALUES (@IDTipoServicio, @Nombre, @Estado)");

                datos.agregarParametro("@IDTipoServicio", nuevo.Id);
                datos.agregarParametro("@Nombre", nuevo.Nombre);
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

        public void modificar(TipoServicio modificar)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta(
                    "update TipoServicios set Nombre = @Nombre, Estado = @Estado where id = "+modificar.Id);

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
                TipoServicio aux = new TipoServicio();

                aux.Id = ID;
                aux.Estado = false;

                datos.setearConsulta(
                    "update TipoServicios set Estado = 0 where ID = " + aux.Id);

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
