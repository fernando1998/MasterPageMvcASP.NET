using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Caso02.Models
{
    public class Venta
    {
        public int cantidad { get; set; }
        public String tipoArroz { get; set; }
        public Double descuento { get; set; }
        public Double total { get; set; }
        public Double totalPagar { get; set; }
    }
}