using System;
using System.Collections.Generic;
using Dominio;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegocioServContratado
    {
        public List<ServicioContratado> listar(string consulta = "")
        {
            List<ServicioContratado> lista = new List<ServicioContratado>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select * ServicioContratado s,  "+ consulta);

                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    ServicioContratado aux = new ServicioContratado();
                    aux.Id = (int)datos.Lector["ID"];
                    aux.Servicio.Id = (int)datos.Lector["IDServicio"];
                    aux.Usuario.Id = (int)datos.Lector["IDUsuario"];
                    aux.Delegado1.Id = (int)datos.Lector["IDDelegado1"];
                    aux.Delegado2.Id = (int)datos.Lector["IDDelegado2"];
                    aux.FechaCompra = (DateTime)datos.Lector["FechaInicio"];
                    aux.FechaCancelacion = (DateTime)datos.Lector["FechaFin"];
                    aux.GrupoSoporte = (string)datos.Lector["GrupoSoporte"];
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

        public void agregar(ServicioContratado nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into ServicioContratado (IDServicio, IDUSuario, IDDelegado1, IDDelegado2, FechaInicio, FechaFin, GrupoSoporte, Estado)" +
                 " VALUES (@IDServicio, @IDUsuario, @IDDelegado1, @IDDelegado2, @FechaInicio, @FechaFin, @GrupoSoporte, @Estado)");

                datos.agregarParametro("@IDServicio", nuevo.Servicio.Id);
                datos.agregarParametro("@IDUsuario", nuevo.Usuario.Id);
                datos.agregarParametro("@IDDelegado1", nuevo.Delegado1.Id);
                datos.agregarParametro("@IDDelegado2", nuevo.Delegado2);
                datos.agregarParametro("@FechaInicio", nuevo.FechaCompra);
                datos.agregarParametro("@FechaFin", nuevo.FechaCancelacion);
                datos.agregarParametro("@GrupoSoporte", nuevo.GrupoSoporte);
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

        public void modificar(ServicioContratado modificar)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta(
                "update ServicioContratado set IDServicio, IDUSuario, IDDelegado1, IDDelegado2, FechaInicio, FechaFin, GrupoSoporte, Estado WHERE id =" + modificar.Id);

                datos.agregarParametro("@IDServicio", modificar.Servicio.Id);
                datos.agregarParametro("@IDUsuario", modificar.Usuario.Id);
                datos.agregarParametro("@IDDelegado1", modificar.Delegado1.Id);
                datos.agregarParametro("@IDDelegado2", modificar.Delegado2);
                datos.agregarParametro("@FechaInicio", modificar.FechaCompra);
                datos.agregarParametro("@FechaFin", modificar.FechaCancelacion);
                datos.agregarParametro("@GrupoSoporte", modificar.GrupoSoporte);
                datos.agregarParametro("@Estado", modificar.Estado);


                datos.ejectutarAccion();


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
                ServicioContratado aux = new ServicioContratado();

                aux.Id = ID;
                aux.Estado = false;

                datos.setearConsulta(
                    "update ServicioContratado set Estado = 0 where ID = " + aux.Id + ""
                    );

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
