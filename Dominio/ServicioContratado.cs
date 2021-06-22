using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ServicioContratado
    {
        public int Id { get; set; }
        public Servicio Servicio { get; set; }
        public Usuario Usuario { get; set; }
        public Usuario Delegado1 { get; set; }
        public Usuario Delegado2 { get; set; }
        public DateTime FechaCompra { get; set; }
        public DateTime FechaCancelacion { get; set; }
        public string GrupoSoporte { get; set; }
        public bool  Estado { get; set; }
    }
}
