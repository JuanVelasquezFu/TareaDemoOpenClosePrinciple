using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOpenClosePrinciple
{
    public class Rhombus : Shape
    {
        public double DiagonaMayor { get; set; }
        public double DiagonaMenor { get; set; }
        public override double Area() => (this.DiagonaMayor * this.DiagonaMenor) / 2;
    }
}
