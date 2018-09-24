using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Caso02.Models
{
    public class Alumno
    {
        public int codigo { get; set; }
        public String nombre { get; set; }
        public String curso { get; set; }
        public Double parcial { get; set; }
        public Double final { get; set; }
        public Double practica { get; set; }
        public Double promedio { get; set; }
        public String estado { get; set; }
    }
}