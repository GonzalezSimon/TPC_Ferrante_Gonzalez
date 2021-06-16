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
        public ServicioContratado Servicio { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime FechaCompra { get; set; }
        public DateTime FechaCancelacion { get; set; }
        public string GrupoSoporte { get; set; }
        public bool  Estado { get; set; }
    }
}
