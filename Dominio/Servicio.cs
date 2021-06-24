using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Servicio
    {
        public long Id { get; set; }
        public TipoServicio Tipo { get; set; }

        public decimal Precio { get; set; }

        public string Descripcion { get; set; }

        public int Slots { get; set; }

        public bool Estado { get; set; }

        public Servicio()
        {
            Tipo = new TipoServicio();
        }
    }
}
