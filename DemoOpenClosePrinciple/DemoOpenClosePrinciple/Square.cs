using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOpenClosePrinciple
{
    public class Square : Shape, ICalculablePerimeter, IResizable
    {
        public double Size {  get; set; }

        public override double Area() => (this.Size*this.Size);

        public double Perimeter() => Math.Round(4 * this.Size, 2);

        public void Resize(double factor) => this.Size *= factor;

    }
}
