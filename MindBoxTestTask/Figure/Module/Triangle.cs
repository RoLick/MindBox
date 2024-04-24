using MindBoxTestTask.Extension;
using MindBoxTestTask.Figure.Abstraction;

namespace MindBoxTestTask.Figure;

public class Triangle(double a, double b, double c) : ITriangle
{
    // sides triangle

    public double CalculateArea()
    {
        Validate();
        // perimentr
        var p = (a + b + c) / 2.0;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }

    public bool IsRightAngled()
    {
        Validate();
        var max = Math.Max(a, Math.Max(b, c));
        return max switch
        {
            _ when a > b && a > c => CalculateAndCheckRightAngled(a, b, c),
            _ when b > a && b > c => CalculateAndCheckRightAngled(b, a, c),
            _ => CalculateAndCheckRightAngled(c, a, b),
        };
    }

    private bool CalculateAndCheckRightAngled(double a, double b, double c)
    {
        // a == sqrt(b^2 + c^2)
        return a.EqualsWithTolerance(Math.Sqrt(Math.Pow(b, 2) + Math.Pow(c, 2)));
    }

    private void Validate()
    {
        if (!(a > 0 && b > 0 && c > 0 && a + b > c && a + c > b && b + c > a))
        {
            throw new Exception($"Треугольник со сторонами 'a={a}, b={b}, c={c}' не существует");
        }
    }
}