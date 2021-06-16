using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Usuario
    {
        public int Id { get; set; }
        public int UserName { get; set; }
        public string Password { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public localidad Localidad { get; set; }
        public TipoUsuario Tipo { get; set; }
        public string URLimagen { get; set; }
        public bool Estado { get; set; }

    }
}
