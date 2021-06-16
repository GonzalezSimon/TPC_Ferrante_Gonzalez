﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Ticket
    {
        public int Id { get; set; }
        public string GrupoSoporte { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime FechaApertura { get; set; }
        public DateTime FechaCierre { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }

    }
}
