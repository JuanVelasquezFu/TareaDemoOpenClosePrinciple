using System;
using System.Collections.Generic;

namespace DemoOpenClosePrinciple
{
    public class ReporteAreas
    {
        private readonly ICalculadoraArea calculadora;

        public ReporteAreas(ICalculadoraArea calculadora)
        {
            this.calculadora = calculadora;
        }

        public void Mostrar(List<Shape> figuras)
        {
            double areaTotal = calculadora.TotalArea(figuras);
            Console.WriteLine($"Cantidad de figuras: {figuras.Count}");
            Console.WriteLine($"Área total: {areaTotal}");
        }
    }
}
