using System;

namespace DemoOpenClosePrinciple
{

    public interface ICalculablePerimeter
    {
        double Perimeter();
    }

    public interface IResizable
    {
        void Resize(double factor);
    }
}
