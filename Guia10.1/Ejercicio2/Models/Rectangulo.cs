using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    public  class Rectangulo: Figuras
    {

        double Ancho { get; set; }
        double Largo { get; set; }

        public Rectangulo(double ancho, double largo, double area:base(area))
        {

        }
        public Rectangulo()
        {

        }

    }
}
