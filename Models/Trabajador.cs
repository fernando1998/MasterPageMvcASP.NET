using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Caso02.Models
{
    public class Trabajador
    {
        public int nroHijos { get; set; }
        public Double comision { get; set; }
        public Double descuento { get; set; }
        public Double sueldoBruto { get; set; }
        public Double sueldoNeto { get; set; }
    }
}