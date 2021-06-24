using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class NegocioServicio
    {

        public List<Servicio> listar(bool combobox = false)
        {
            List<Servicio> lista = new List<Servicio>();

            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select IDServicio, ts.IDTipoServicio, ts.Nombre, ts.Estado, Precio, Descripcion, Slots, EstadoServicio from Servicios as s" +
                    "inner join TipoServicio as ts on ts.IDTipoServicio = s.IDTipoServicio");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Servicio aux = new Servicio();

                    aux.Id = (long)datos.Lector["IDServicio"];
                    //carga de TipoServicio
                    aux.Tipo.Id = (int)datos.Lector["IDTipoServicio"];
                    aux.Tipo.Nombre = (string)datos.Lector["ts.Nombre"];
                    aux.Tipo.Estado = (bool)datos.Lector["ts.Estado"];

                    aux.Precio = (decimal)datos.Lector["Precio"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Slots = (int)datos.Lector["Slots"];
                    aux.Estado = (bool)datos.Lector["EstadoServicio"];

                    if(aux.Estado == true) lista.Add(aux);
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

        public void agregar(Servicio nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {

                datos.setearConsulta("insert into Servicios (IDTipoServicio, Precio, Descripcion, Slots, Estado)" +
                " VALUES (@IDTipoServicio, @Precio, @Descripcion, @Slots, @Estado)");

                datos.agregarParametro("@IDTipoServicio", nuevo.Tipo.Id);
                datos.agregarParametro("@Precio", nuevo.Precio);
                datos.agregarParametro("@Descripcion", nuevo.Descripcion);
                datos.agregarParametro("@Slots", nuevo.Slots);
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

        public void modificar(Servicio modificar)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta(
                "update Servicios set IDTipoServicio = @IDTipoServicio, Precio = @Precio, Descripcion = @Descripcion, Slots = @Slots, Estado = @Estado WHERE id =" + modificar.Id);

                datos.agregarParametro("@IDTipoServicio", modificar.Tipo.Id);
                datos.agregarParametro("@Precio", modificar.Precio);
                datos.agregarParametro("@Descripcion", modificar.Descripcion);
                datos.agregarParametro("@Slots", modificar.Slots);
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
                Servicio aux = new Servicio();

                aux.Id = ID;
                aux.Estado = false;

                datos.setearConsulta(
                    "update Servicios set EstadoServicio = 0 where ID = " + aux.Id);

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
