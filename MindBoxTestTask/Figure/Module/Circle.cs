using MindBoxTestTask.Figure.Abstraction;

namespace MindBoxTestTask.Figure;

public class Circle : IFigure
{
    private double _radius;

    public Circle(double radius)
    {
        _radius = radius;
    }

    public double CalculateArea()
    {
        if (double.IsNaN(_radius) || _radius <= 0)
        {
            throw new Exception("Радиус не может быть меньше нуля");
        }
        
        return Math.PI * Math.Pow(_radius, 2);
    }
}