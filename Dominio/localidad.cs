using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Localidad
    {
        public long Id { get; set; }
        public string Nombre { get; set; }
        public Pais Pais { get; set; }
        public bool Estado { get; set; }

        public Localidad()
        {
            Pais = new Pais();
        }
    }
}
