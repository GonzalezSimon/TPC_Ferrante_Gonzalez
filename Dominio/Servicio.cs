using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Servicio
    {
        public int Id { get; set; }
        public TipoServicio Tipo { get; set; }

        public double Precio { get; set; }

        public int Slots { get; set; }

        public bool Estado { get; set; }
    }
}
