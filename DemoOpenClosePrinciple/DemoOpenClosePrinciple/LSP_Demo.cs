using System;
using System.Collections.Generic;

namespace DemoOpenClosePrinciple
{
    public abstract class LSPDemo
    {
        public static void ImprimirAreaDeCadaFigura(List<Shape> shapes)
        {
            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"Área: {Math.Round(shape.Area(), 2)}");
            }
        }
    }
}
