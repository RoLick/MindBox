using MindBoxTestTask.Figure.Abstraction;

namespace MindBoxTestTask.Figure;

public class Circle : IFigure
{
    private double _radius;

    public Circle(double radius)
    {
        _radius = radius;
    }

    public double GetSquare()
    {
        return Math.PI * Math.Pow(_radius, 2);
    }
}