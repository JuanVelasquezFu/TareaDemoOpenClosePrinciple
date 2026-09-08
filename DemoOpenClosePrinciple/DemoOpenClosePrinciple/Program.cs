using DemoOpenClosePrinciple;
using System.Drawing;

AreaCalculator calculator = new AreaCalculator();

Circle circle1 = new Circle();
circle1.Radius = 2;

Circle circle2 = new Circle();
circle2.Radius = 3;

Circle circle3 = new Circle();
circle3.Radius = 4;


Square square1 = new Square();
square1.Size = 5;

Square square2 = new Square();
square2.Size = 4;

Square square3 = new Square();
square3.Size = 7;

Triangulo triangulo1 = new Triangulo();
triangulo1.Base = 5;
triangulo1.Altura = 2;

Triangulo triangulo2 = new Triangulo();
triangulo2.Base = 4;
triangulo2.Altura = 3;

Triangulo triangulo3= new Triangulo();
triangulo3.Base = 8;
triangulo3.Altura = 8;

Pentagon pentagon = new Pentagon();
pentagon.Perimetro = 25;
pentagon.Apotema = 3.44;

Pentagon pentagon2 = new Pentagon();
pentagon2.Perimetro = 30;
pentagon2.Apotema = 0;

Rhombus rhombus1 = new Rhombus();
rhombus1.DiagonaMayor = 6;
rhombus1.DiagonaMenor = 4;

Rhombus rhombus2 = new Rhombus();
rhombus2.DiagonaMayor = 8;
rhombus2.DiagonaMenor = 5;

List<Shape> shapes = new List<Shape>();
shapes.Add(circle1);
shapes.Add(circle2);
shapes.Add(circle3);
shapes.Add(square1);
shapes.Add(square2);
shapes.Add(square3);
shapes.Add(triangulo1);
shapes.Add(triangulo2);
shapes.Add(triangulo3);
shapes.Add(pentagon);
shapes.Add(pentagon2);
shapes.Add(rhombus1);
shapes.Add(rhombus2);


var resultTotalArea = Math.Round(calculator.TotalArea(shapes), 2);

Console.WriteLine($"El área total es {resultTotalArea}");
Console.WriteLine("\n--- Demostración LSP ---");
LSPDemo.ImprimirAreaDeCadaFigura(shapes);
Console.WriteLine("\n--- Demostración ISP ---");
Console.WriteLine($"Perímetro circle1: {circle1.Perimeter()}");
Console.WriteLine($"Perímetro square1: {square1.Perimeter()}");
circle1.Resize(2);
Console.WriteLine($"Radio de circle1 tras Resize(2): {circle1.Radius}");
Console.WriteLine("\n--- Demostración DIP ---");
ICalculadoraArea calculadoraAbstracta = new AreaCalculator();
ReporteAreas reporte = new ReporteAreas(calculadoraAbstracta);
reporte.Mostrar(shapes);