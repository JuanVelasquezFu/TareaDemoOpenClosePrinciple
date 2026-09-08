using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOpenClosePrinciple
{
    public class Pentagon:Shape
    {
        public double Perimetro { get; set; }
        public double Apotema { get; set; }

        public override double Area() => (Perimetro * Apotema) / 2;
    }
}
