using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegocioPais
    {
        public List<Pais> listar(bool combobox = false)
        {
            List<Pais> lista = new List<Pais>();

            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select ID, Nombre, Estado from Paises");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Pais aux = new Pais();

                    aux.Id = (int)datos.Lector["ID"];
                    aux.Nombre = (string)datos.Lector["Nombre"];

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

        public void agregar(Pais nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string valores = "values('"
                    + nuevo.Nombre + "')";

                datos.setearConsulta("insert into Paises (Nombre) "
                    + valores);

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

        public void modificar(Pais modificar)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta(
                    "update Paises set Nombre = '" + modificar.Nombre + "' where ID = " + modificar.Id);

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
                Pais aux = new Pais();

                aux.Id = ID;
                aux.Estado = false;

                datos.setearConsulta(
                    "update Paises set Estado = 0 where ID = " + aux.Id);

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
