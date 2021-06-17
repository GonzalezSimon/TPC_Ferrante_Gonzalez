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
                    //aux.Id = (int)datos.Lector["IDServicio"];
                    //aux.Servicio= new Servicio( datos.Lector["Codigo"]);
                    //aux.Nombre = (string)datos.Lector["Nombre"];
                    //aux.Descripcion = (string)datos.Lector["Descripcion"];

                    //aux.Marca = new Marca((string)datos.Lector["Marca"]);
                    //aux.Marca.ID = ((int)datos.Lector["IDMarca"]);

                    //aux.Categoria = new Categoria((string)datos.Lector["Categoria"]);
                    //aux.Categoria.ID = ((int)datos.Lector["IDCategoria"]);

                    //aux.UrlImagen = (string)datos.Lector["ImagenUrl"];
                    //aux.Precio = float.Parse(datos.Lector["Precio"].ToString());
                    //aux.Stock = float.Parse(datos.Lector["Stock"].ToString());
                    //aux.Estado = (bool)datos.Lector["Estado"];

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

        public void agregar(ServicioContratado nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string valores = "values('"+ nuevo.Servicio.Id + "','" + nuevo.Usuario.Id + "', '" + nuevo.Delegado1.Id + "', '"+ nuevo.Delegado2.Id + "', "
                    + nuevo.FechaCompra + ", "
                    + nuevo.FechaCancelacion + ", '"
                    + nuevo.GrupoSoporte 
                    + "', 1 )";

                datos.setearConsulta("insert into Articulos(Codigo, Nombre, Descripcion,IDMarca,IDCategoria,ImagenUrl,Precio,Stock,Estado)" + valores);


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


                //datos.setearConsulta("update Articulos set codigo = '" + modificar.Codigo + "', nombre = '" + modificar.Nombre + "', Descripcion = '" + modificar.Descripcion +
                //    "', IdMarca = " + modificar.Marca.ID + ", IdCategoria = " + modificar.Categoria.ID + ", ImagenUrl = '" + modificar.UrlImagen + "', Precio = " + modificar.Precio + ", Stock = " + modificar.Stock + ", Estado = 1 WhERE id = " + modificar.ID + ";");

                //datos.setearConsulta("update Articulos set codigo = @codigo, nombre = @nombre, Descripcion = @descripcion, IdMarca = @IDMarca, IdCategoria = @IDCategoria, ImagenUrl = @imagenUrl, Precio = @precio, Stock = @stock, Estado = 1 WhERE Id = " + modificar.ID + "");

                //datos.agregarParametro("@codigo", modificar.Codigo);
                //datos.agregarParametro("@nombre", modificar.Nombre);
                //datos.agregarParametro("@descripcion", modificar.Descripcion);
                //datos.agregarParametro("@IDMarca", modificar.Marca.ID);
                //datos.agregarParametro("@IDCategoria", modificar.Categoria.ID);
                //datos.agregarParametro("@imagenUrl", modificar.UrlImagen);
                //datos.agregarParametro("@precio", modificar.Precio);
                //datos.agregarParametro("@stock", modificar.Stock);


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

                //aux.ID = ID;
                //aux.Estado = false;

                //datos.setearConsulta(
                //    "update Articulos set Estado = 0 where ID = " + aux.ID + ""
                //    );

                //datos.ejectutarAccion();

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
