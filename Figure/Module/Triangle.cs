using MindBoxTestTask.Figure.Abstraction;

namespace MindBoxTestTask.Figure;

public class Triangle(double a, double b, double c) : ITriangle
{
    // sides triangle

    public double GetSquare()
    {
        // perimentr
        var p = (a + b + c) / 2.0;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }

    public bool IsRightAngled()
    {
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
        return Math.Abs(a - Math.Sqrt(Math.Pow(b, 2) + Math.Pow(c, 2))) < 0.01;
    }
    
}