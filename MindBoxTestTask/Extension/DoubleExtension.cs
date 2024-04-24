namespace MindBoxTestTask.Extension;

public static class DoubleExtension
{
    private const double _1 = 0.1;
    private const double _2 = 0.01;
    private const double _3 = 0.001;
    private const double _4 = 0.0001;
    private const double _5 = 0.00001;
    private const double _6 = 0.000001;
    private const double _7 = 0.0000001;
    
    public static bool EqualsWithTolerance(this double left, double right, int toleranceRate = 2)
    {
        if (double.IsNaN(left) && double.IsNaN(right))
        {
            return true;
        }
        
        var tolerance = toleranceRate switch
        {
            1 => _1,
            2 => _2,
            3 => _3,
            4 => _4,
            5 => _5,
            6 => _6,
            7 => _7,
            _ => _2
        };

        return Math.Abs(left - right) < tolerance;
    }
}