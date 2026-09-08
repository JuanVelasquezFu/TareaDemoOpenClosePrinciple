using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOpenClosePrinciple
{
    public interface ICalculadoraArea
    {
        double TotalArea(List<Shape> shapes);
    }

    public class AreaCalculator : ICalculadoraArea
    {

        public double TotalArea(List<Shape> shapes) => Math.Round(shapes.Sum(item => item.Area()), 2);
       
            /*
        {
            double sumatoria = 0;
            foreach (Shape shape in shapes)
            {
                sumatoria += shape.Area();
            }

            return sumatoria;
        }
            */
       

    }
}
