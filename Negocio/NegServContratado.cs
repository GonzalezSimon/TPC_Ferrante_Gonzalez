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
            /*AccesoDatos del1 = new AccesoDatos();
            AccesoDatos del2 = new AccesoDatos();*/

            /*try
            {*/
            datos.setearConsulta("select sc.IDSuscripcion, s.IDServicio, s.IDTipoServicio, ts.TipoServicio, ts.Estado EstadoT, s.Precio, s.Descripcion, " +
                "s.Slots, s.URLServicio, s.EstadoServicio, u.IDUsuario, U.Usuario, u.UPassword, u.Apellido, u.Nombre, u.Telefono, u.Mail, l.IDLocalidad," +
                " l.Nombre NombreL, l.Estado EstadoL, p.IDPais, p.Nombre NombreP, p.Estado EstadoP, tu.IDTipoUsuario, tu.TipoUsuario TipoUsuario, tu.Estado EstadoTu, u.URLUsuario, u.FechaCreacion," +
                " u.EstadoUsuario, sc.FechaInicio, sc.Fechafin, sc.GrupoSoporte, sc.EstadoSXC from Suscripciones as sc " +
                "inner join Servicios as s on s.IDServicio = sc.IDServicio " +
                "inner join TipoServicio as ts on ts.IDTipoServicio = s.IDTipoServicio " +
                "inner join Usuarios as U on u.IDUsuario = sc.IDUsuario " +
                "inner join TipoUsuario as tu on tu.IDTipoUsuario = u.IDTipoUsuario " +
                "inner join localidades as L on L.IDlocalidad = u.IDLocalidad " +
                "inner join paises as p on p.IDPais = L.IDPais" + consulta);

            datos.ejecutarLectura();
            #region whiles 1
            /*del1.setearConsulta("select " +
                " u.IDUsuario, U.Usuario, u.UPassword, u.Apellido, u.Nombre, u.Telefono, u.Mail, " +
                " l.IDLocalidad, l.Nombre, l.Estado," +
                " p.IDPais, p.Nombre, p.Estado," +
                " tu.IDTipoUsuario, tu.TipoUsuario, tu.Estado," +
                " u.URLUsuario, u.FechaCreacion, u.EstadoUsuario from ServicioContratado as SC" +
                " inner join Usuarios as u on u.IDUsuario = sc.IDUsuario" +
                " inner join Localidad as l on l.IDLocalidad = u.IDlocalidad" +
                " inner join Pais as p on p.IDPais = l.IDPais" +
                " inner join TipoUsuario as TU on tu.IDTipoUsuario = u.IDTipoUsuario");
            del1.ejecutarLectura();

            del2.setearConsulta("select " +
                " u.IDUsuario, U.Usuario, u.UPassword, u.Apellido, u.Nombre, u.Telefono, u.Mail, " +
                " l.IDLocalidad, l.Nombre, l.Estado," +
                " p.IDPais, p.Nombre, p.Estado," +
                " tu.IDTipoUsuario, tu.TipoUsuario, tu.Estado," +
                " u.URLUsuario, u.FechaCreacion, u.EstadoUsuario from ServicioContratado as SC" +
                " inner join Usuarios as u on u.IDUsuario = sc.IDUsuario" +
                " inner join Localidad as l on l.IDLocalidad = u.IDlocalidad" +
                " inner join Pais as p on p.IDPais = l.IDPais" +
                " inner join TipoUsuario as TU on tu.IDTipoUsuario = u.IDTipoUsuario");
            del2.ejecutarLectura();*/
            #endregion
            int cont = 0;

            #region prev
            //while (datos.Lector.Read())
            //    {
            //        cont++;
            //        //long au= (long)datos.Lector["s.IDServicio"];
            //        ////carga de servicio
            //        //aux.Servicio.Id =(long)datos.Lector["s.IDServicio"];
            //        //aux.Servicio.Precio = (double)datos.Lector["s.Precio"];
            //        //aux.Servicio.Descripcion = (string)datos.Lector["s.Descripcion"];
            //        //aux.Servicio.Slots = (int)datos.Lector["s.Slots"];
            //        //aux.Servicio.Estado = (bool)datos.Lector["s.EstadoServicio"];
            //        ////carga tipoServicio
            //        //aux.Servicio.Tipo.Id = (int)datos.Lector["TS.IDTipoServicio"];
            //        //aux.Servicio.Tipo.Nombre = (string)datos.Lector["TS.TipoServicio"];
            //        //aux.Servicio.Tipo.Estado = (bool)datos.Lector["ts.Estado"];


            //        //carga UsuarioADMIN                        
            //        aux.Usuario.Id = (long)datos.Lector["u.IDUsuario"];
            //        aux.Usuario.UserName = (string)datos.Lector["u.Usuario"];
            //        aux.Usuario.Password = (string)datos.Lector["u.UPassword"];
            //        aux.Usuario.Apellido = (string)datos.Lector["u.Apellido"];
            //        aux.Usuario.Nombre = (string)datos.Lector["u.Nombre"];
            //        aux.Usuario.Telefono = (string)datos.Lector["u.Telefono"];
            //        aux.Usuario.Mail = (string)datos.Lector["u.Mail"];

            //        //Carga de Localidad
            //        aux.Usuario.Localidad.Id = (long)datos.Lector["u.IDLocalidad"];
            //        aux.Usuario.Localidad.Nombre = (string)datos.Lector["L.Nombre"];
            //        aux.Usuario.Localidad.Estado = (bool)datos.Lector["Estado"];

            //        //Carga de Pais
            //        aux.Usuario.Localidad.Pais.Id = (int)datos.Lector["p.IDPais"];
            //        aux.Usuario.Localidad.Pais.Nombre = (string)datos.Lector["p.Nombre"];
            //        aux.Usuario.Localidad.Pais.Estado = (bool)datos.Lector["P.Estado"];

            //        //Carga de tipo
            //        aux.Usuario.Tipo.Estado = (bool)datos.Lector["TU.Estado"];
            //        aux.Usuario.Tipo.Nombre = (string)datos.Lector["TU.Nombre"];
            //        aux.Usuario.Tipo.Id = (int)datos.Lector["tu.IDTipoUsuario"];

            //        aux.Usuario.URLimagen = (string)datos.Lector["u.URLUsuario"];
            //        aux.Usuario.FechaCreacion = (DateTime)datos.Lector["u.FechaCreacion"];
            //        aux.Usuario.Estado = (bool)datos.Lector["u.EstadoUsuario"];

            //        #region Whiles
            //        /* while (del2.Lector.Read())
            //         {
            //             //carga usuario/Delegado1
            //             aux.Delegado1.Id = (long)datos.Lector["u.IDUsuario"];
            //             aux.Delegado1.UserName = (string)datos.Lector["u.Usuario"];
            //             aux.Delegado1.Password = (string)datos.Lector["u.UPassword"];
            //             aux.Delegado1.Apellido = (string)datos.Lector["u.Apellido"];
            //             aux.Delegado1.Nombre = (string)datos.Lector["u.Nombre"];
            //             aux.Delegado1.Telefono = (string)datos.Lector["u.Telefono"];
            //             aux.Delegado1.Mail = (string)datos.Lector["u.Mail"];

            //             //Carga de Localidad
            //             aux.Delegado1.Localidad.Id = (long)datos.Lector["u.IDLocalidad"];
            //             aux.Delegado1.Localidad.Nombre = (string)datos.Lector["L.Nombre"];
            //             aux.Delegado1.Localidad.Estado = (bool)datos.Lector["Estado"];

            //             //Carga de Pais
            //             aux.Delegado1.Localidad.Pais.Id = (int)datos.Lector["p.IDPais"];
            //             aux.Delegado1.Localidad.Pais.Nombre = (string)datos.Lector["p.Nombre"];
            //             aux.Delegado1.Localidad.Pais.Estado = (bool)datos.Lector["P.Estado"];

            //             //Carga de tipo
            //             aux.Delegado1.Tipo.Estado = (bool)datos.Lector["TU.Estado"];
            //             aux.Delegado1.Tipo.Nombre = (string)datos.Lector["TU.Nombre"];
            //             aux.Delegado1.Tipo.Id = (int)datos.Lector["u.IDTipoUsuario"];

            //             aux.Delegado1.URLimagen = (string)datos.Lector["URLUsuario"];
            //             aux.Delegado1.FechaCreacion = (DateTime)datos.Lector["FechaCreacion"];
            //             aux.Delegado1.Estado = (bool)datos.Lector["EstadoUsuario"];
            //         }
            //         while (del1.Lector.Read())
            //         {
            //             //carga usuario/Delegado2
            //             aux.Delegado2.Id = (long)datos.Lector["u.IDUsuario"];
            //             aux.Delegado2.UserName = (string)datos.Lector["u.Usuario"];
            //             aux.Delegado2.Password = (string)datos.Lector["u.UPassword"];
            //             aux.Delegado2.Apellido = (string)datos.Lector["u.Apellido"];
            //             aux.Delegado2.Nombre = (string)datos.Lector["u.Nombre"];
            //             aux.Delegado2.Telefono = (string)datos.Lector["u.Telefono"];
            //             aux.Delegado2.Mail = (string)datos.Lector["u.Mail"];

            //             //Carga de Localidad
            //             aux.Delegado2.Localidad.Id = (long)datos.Lector["u.IDLocalidad"];
            //             aux.Delegado2.Localidad.Nombre = (string)datos.Lector["L.Nombre"];
            //             aux.Delegado2.Localidad.Estado = (bool)datos.Lector["Estado"];

            //             //Carga de Pais
            //             aux.Delegado2.Localidad.Pais.Id = (int)datos.Lector["p.IDPais"];
            //             aux.Delegado2.Localidad.Pais.Nombre = (string)datos.Lector["p.Nombre"];
            //             aux.Delegado2.Localidad.Pais.Estado = (bool)datos.Lector["P.Estado"];

            //             //Carga de tipo
            //             aux.Delegado2.Tipo.Estado = (bool)datos.Lector["TU.Estado"];
            //             aux.Delegado2.Tipo.Nombre = (string)datos.Lector["TU.Nombre"];
            //             aux.Delegado2.Tipo.Id = (int)datos.Lector["u.IDTipoUsuario"];

            //             aux.Delegado2.URLimagen = (string)datos.Lector["URLUsuario"];
            //             aux.Delegado2.FechaCreacion = (DateTime)datos.Lector["FechaCreacion"];
            //             aux.Delegado2.Estado = (bool)datos.Lector["EstadoUsuario"];
            //         }*/
            //        #endregion

            //        aux.FechaCompra = (DateTime)datos.Lector["FechaInicio"];
            //        aux.FechaCancelacion = (DateTime)datos.Lector["FechaFin"];
            //        aux.GrupoSoporte = (string)datos.Lector["GrupoSoporte"];
            //        aux.Estado = (bool)datos.Lector["EstadoSXC"];

            //        if (aux.Estado == true)
            //            lista.Add(aux);
            //    }

            //    return lista;
            ///*}

            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            //finally
            //{*/
            //    datos.cerrarConexion();
            ///*}*/
            #endregion
            try {
                while (datos.Lector.Read())
                {
                    ServicioContratado aux = new ServicioContratado();


                    aux.Id = (long)datos.Lector["IDSuscripcion"];
                    /*Servicio*/

                    aux.Servicio.Id = (long)datos.Lector["IDServicio"];
                    aux.Servicio.Precio = (decimal)datos.Lector["Precio"];
                    aux.Servicio.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Servicio.Slots = (int)datos.Lector["Slots"];
                    aux.Servicio.URLServicio = (string)datos.Lector["URLServicio"];
                    aux.Servicio.Estado = (bool)datos.Lector["EstadoServicio"];
                    

                    /*Tipo de Servicios*/
                    aux.Servicio.Tipo.Id = (int)datos.Lector["IDTipoServicio"];
                    aux.Servicio.Tipo.Nombre = (string)datos.Lector["TipoServicio"];
                    aux.Servicio.Tipo.Estado = (bool)datos.Lector["EstadoT"];

                    /*Usuarios*/
                    aux.Usuario.Id = (long)datos.Lector["IDUsuario"];
                    aux.Usuario.Nombre = (string)datos.Lector["Nombre"];
                    aux.Usuario.Apellido = (string)datos.Lector["Apellido"];
                    aux.Usuario.UserName = (string)datos.Lector["Usuario"];
                    aux.Usuario.Password = (string)datos.Lector["UPassword"];
                    aux.Usuario.Telefono = (string)datos.Lector["Telefono"];
                    aux.Usuario.Mail = (string)datos.Lector["Mail"];
                    aux.Usuario.URLimagen = (string)datos.Lector["URLUsuario"];
                    aux.Usuario.FechaCreacion = (DateTime)datos.Lector["FechaCreacion"];
                    aux.Usuario.Estado = (bool)datos.Lector["EstadoUsuario"];

                    /*Carga de Localidad*/
                    aux.Usuario.Localidad.Id = (long)datos.Lector["IDLocalidad"];
                    aux.Usuario.Localidad.Nombre = (string)datos.Lector["NombreL"];
                    aux.Usuario.Localidad.Estado = (bool)datos.Lector["EstadoL"];

                    //Carga de Pais
                    aux.Usuario.Localidad.Pais.Id = (int)datos.Lector["IDPais"];
                    aux.Usuario.Localidad.Pais.Nombre = (string)datos.Lector["NombreP"];
                    aux.Usuario.Localidad.Pais.Estado = (bool)datos.Lector["EstadoP"];

                    //Carga de tipo
                    aux.Usuario.Tipo.Estado = (bool)datos.Lector["EstadoTu"];
                    aux.Usuario.Tipo.Nombre = (string)datos.Lector["TipoUsuario"];
                    aux.Usuario.Tipo.Id = (int)datos.Lector["IDTipoUsuario"];



                    /*Servicio Contratado*/
                    aux.FechaCompra = (DateTime)datos.Lector["FechaInicio"];
                    aux.FechaCancelacion = (DateTime)datos.Lector["FechaFin"];
                    aux.GrupoSoporte = (string)datos.Lector["GrupoSoporte"];
                    aux.Estado = (bool)datos.Lector["EstadoSXC"];

                    cont = 0;
                    if (aux.Estado)
                    {
                        lista.Add(aux);
                    }
                    cont = 3;
                }
                
            }
            catch(Exception)
            {

            }
            return lista;

        }

        public void agregar(ServicioContratado nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into ServicioContratado (IDServicio, IDUSuario, IDDelegado1, IDDelegado2, FechaInicio, FechaFin, GrupoSoporte, EstadoSXC)" +
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
