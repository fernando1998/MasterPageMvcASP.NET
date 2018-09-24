using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Caso02.Models
{
    public class Compra
    {
        public int cantidad { get; set; }
        public Double precio { get; set; }
        public Double primerDesc { get; set; }
        public Double segundoDesc { get; set; }
        public Double totalDesc { get; set; }
        public Double total { get; set; }
    }
}