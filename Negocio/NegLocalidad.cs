using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegocioLocalidad
    {
        public List<Localidad> listar(bool combobox = false)
        {
            List<Localidad> lista = new List<Localidad>();

            AccesoDatos datos = new AccesoDatos();
                       
            try
            {
                datos.setearConsulta("select ID, Nombre, Estado from Localidades");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Localidad aux = new Localidad();

                    aux.Id = (int)datos.Lector["ID"];
                    aux.Nombre = (string)datos.Lector["Descripcion"];
                    aux.IdPais = (int)datos.Lector["ID"];

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

        public void agregar(Localidad nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string valores = "values('"
                    + nuevo.Nombre + "'," 
                    + nuevo.IdPais +")";

                datos.setearConsulta("insert into Localidades (Nombre, IDPais)" + valores);

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

        public void modificar(Localidad modificar)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta(
                    "update Localidades set Nombre = @Nombre, IDPais = @IDPais");

                datos.agregarParametro("@Nombre", modificar.Nombre);
                datos.agregarParametro("@IDPais", modificar.IdPais);

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
                Localidad aux = new Localidad();

                aux.Id = ID;
                aux.Estado = false;

                datos.setearConsulta(
                    "update Localidades set Estado = 0 where ID = " + aux.Id);

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
