using MindBoxTestTask.Figure.Abstraction;

namespace MindBoxTestTask.Figure;

public class Circle(double radius) : IFigure
{
    public double CalculateArea()
    {
        if (double.IsNaN(radius) || radius <= 0)
        {
            throw new Exception("Радиус не может быть меньше нуля");
        }
        
        return Math.PI * Math.Pow(radius, 2);
    }
}