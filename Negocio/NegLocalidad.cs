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
                datos.setearConsulta("select IDLocalidad, L.Nombre, L.Estado, p.IDPais idpaisP, p.Nombre nombreP, P.Estado EstadoP from Localidades as L inner join Paises as P on L.IDpais = p.IDpais");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Localidad aux = new Localidad();

                    aux.Id = (long)datos.Lector["IDLocalidad"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Estado = (bool)datos.Lector["Estado"];
                    //carga pais
                    aux.Pais.Id = (int)datos.Lector["idpaisP"];
                    aux.Pais.Nombre = (string)datos.Lector["nombreP"];
                    aux.Pais.Estado = (bool)datos.Lector["EstadoP"];

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
                    + nuevo.Pais.Id +", 1)";//1 para estado true by default

                datos.setearConsulta("insert into Localidades (Nombre, IDPais, Estado)" + valores);

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
                datos.agregarParametro("@IDPais", modificar.Pais.Id);

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
