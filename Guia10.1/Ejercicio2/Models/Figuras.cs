using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    public abstract class Figuras
    {
        int Id { get; set; }
        double Area { get; set; }

        public Figuras (double area)
        {
            Area = area;
        }
        public Figuras()
        {

        }

    }
}
