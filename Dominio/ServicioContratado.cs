using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ServicioContratado
    {
        public long Id { get; set; }
        public Servicio Servicio { get; set; }
        public Usuario Usuario { get; set; }
        public Usuario Delegado1 { get; set; }
        public Usuario Delegado2 { get; set; }
        public DateTime FechaCompra { get; set; }
        public DateTime FechaCancelacion { get; set; }
        public string GrupoSoporte { get; set; }
        public bool  Estado { get; set; }

        public ServicioContratado()
        {
            Servicio = new Servicio();
            Usuario = new Usuario();
            Delegado1 = new Usuario();
            Delegado2 = new Usuario();
        }

        public static ServicioContratado operator +(ServicioContratado serv, ServicioContratado _serv)
        {
            if(serv.Id != _serv.Id)
            {
                serv.Id = _serv.Id;
            }

            if (serv.Servicio.Id != _serv.Servicio.Id && _serv != null)
            {
                serv.Servicio.Id = _serv.Servicio.Id;
            }

            if(serv.Usuario.Id != _serv.Usuario.Id && _serv != null)
            {
                serv.Usuario.Id = _serv.Usuario.Id;
            }

            if (serv.Delegado1.Id != _serv.Delegado1.Id && _serv != null)
            {
                serv.Delegado1.Id = _serv.Delegado1.Id;
            }

            if (serv.Delegado2.Id != _serv.Delegado2.Id && _serv != null)
            {
                serv.Delegado2.Id = _serv.Delegado2.Id;
            }


            if(serv.FechaCompra != _serv.FechaCompra && _serv != null)
            {
                serv.FechaCompra = _serv.FechaCompra;
            }

            if(serv.FechaCancelacion != _serv.FechaCancelacion && _serv != null)
            {
                serv.FechaCancelacion = _serv.FechaCancelacion;
            }

            if(serv.GrupoSoporte != _serv.GrupoSoporte && _serv.GrupoSoporte != "")
            {
                serv.GrupoSoporte = _serv.GrupoSoporte;
            }

            if(serv.Estado != _serv.Estado && _serv != null)
            {
                serv.Estado = _serv.Estado;
            }

            return serv;
        }

    }
}
