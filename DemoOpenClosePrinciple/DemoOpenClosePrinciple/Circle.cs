using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOpenClosePrinciple
{
    public class Circle : Shape, ICalculablePerimeter, IResizable
    {
        public double Radius {  get; set; }

        public override double Area() => (this.Radius * this.Radius * Math.PI);
        /*
        { 
            double area = this.Radius * this.Radius * Math.PI;
            return area; 
        }
        */

        public double Perimeter() => Math.Round(2 * Math.PI * this.Radius, 2);

        public void Resize(double factor) => this.Radius *= factor;

    }
}
