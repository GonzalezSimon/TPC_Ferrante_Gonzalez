﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Localidad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public  int IdPais { get; set; }
        public bool Estado { get; set; }
    }
}
