using System;
using Dominio;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegVideoJuegos
    {
        public List<VideoJuegos> listar(bool combobox = false)
        {
            List<VideoJuegos> lista = new List<VideoJuegos>();

            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select IDJuego, Nombre, Empresa, Imagen, Estado from Juegos order by Nombre desc");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    VideoJuegos aux = new VideoJuegos();

                    aux.Id = (int)datos.Lector["IDJuego"];
                    //carga de TipoServicio
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Empresa = (string)datos.Lector["Empresa"];
                    aux.Imagen = (string)datos.Lector["Imagen"];

                    aux.Estado = (bool)datos.Lector["Estado"];
                    

                    if (aux.Estado == true) lista.Add(aux);
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

        public void agregar(VideoJuegos nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {

                datos.setearConsulta("insert into Juegos (Nombre, Empresa, Imagen, Estado)" +
                " VALUES (@Nombre, @Empresa, @Imagen, @Estado)");

                //datos.agregarParametro("@IDJuego", nuevo.Id);
                datos.agregarParametro("@Nombre", nuevo.Nombre);
                datos.agregarParametro("@Empresa", nuevo.Empresa);
                datos.agregarParametro("@Imagen", nuevo.Imagen);
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

        public void modificar(VideoJuegos modificar)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta(
                "update Juegos set IDJuego = @IDJuego, Nombre = @Nombre, Empresa = @Empresa, Imagen = @Imagen, Estado = @Estado WHERE IDJuego =" + modificar.Id);

                datos.agregarParametro("@IDJuego", modificar.Id);
                datos.agregarParametro("@Nombre", modificar.Nombre);
                datos.agregarParametro("@Empresa",modificar.Empresa);
                datos.agregarParametro("@Imagen", modificar.Imagen);
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
                VideoJuegos aux = new VideoJuegos();

                aux.Id = ID;
                aux.Estado = false;

                datos.setearConsulta(
                    "update Juegos set Estado = 0 where IDJuego = " + aux.Id);

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

