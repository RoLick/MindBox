using MindBoxTestTask.Extension;
using MindBoxTestTask.Figure;
using MindBoxTestTask.Figure.Abstraction;

namespace MindBoxTestTask.Test;

public class TriangleTests
{
    [Theory]
    [InlineData(2.0, 3.0, 4.0, 2.904)]
    [InlineData(3, 4, 5, 6)]
    public void TriangleAreaTests(double a, double b, double c, double output)
    {
        //Arrange
        IFigure figure = new Triangle(a, b, c);
        
        //Act
        var result = figure.CalculateArea();
        
        //Assert
        Assert.True(result.EqualsWithTolerance(output));
    }
    
    [Theory]
    [InlineData(2.0, 3.0, 4.0, false)]
    [InlineData(3, 4, 5, true)]
    public void TriangleIsRightAngledTests(double a, double b, double c, bool output)
    {
        //Arrange
        ITriangle figure = new Triangle(a, b, c);
        
        //Act
        var result = figure.IsRightAngled();
        
        //Assert
        Assert.Equal(result, output);
    }
    
    [Theory]
    [InlineData(double.NaN, 1, 1)]
    [InlineData(1, double.NaN, 1)]
    [InlineData(1, 1, double.NaN)]   
    [InlineData(double.NaN, double.NaN, 1)]
    [InlineData(1, double.NaN, double.NaN)]
    [InlineData(double.NaN, double.NaN, double.NaN)]
    public void TriangleThrowExceptionTests(double a, double b, double c)
    {
        //Arrange
        IFigure figure = new Triangle(a, b, c);
        
        //Act
        var func = () => figure.CalculateArea() as object;
        
        //Assert
        Assert.Throws<Exception>(func);
    }
}