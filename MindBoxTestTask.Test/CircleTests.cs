using MindBoxTestTask.Extension;
using MindBoxTestTask.Figure;
using MindBoxTestTask.Figure.Abstraction;

namespace MindBoxTestTask.Test;

public class FigureGetSquareTests
{
    [Theory]
    [InlineData(1.0, Math.PI)]
    [InlineData(2.1, 13.8474)]
    public void CircleAreaTests(double radius, double output)
    {
        //Arrange
        IFigure figure = new Circle(radius);
        
        //Act
        var result = figure.CalculateArea();
        
        //Assert
        Assert.True(result.EqualsWithTolerance(output));
    }
    
    [Theory]
    [InlineData(double.NaN)]
    [InlineData(0)]
    public void CircleThrowExceptionTests(double radius)
    {
        //Arrange
        IFigure figure = new Circle(radius);
        
        //Act
        var func = () => figure.CalculateArea() as object;
        
        //Assert
        Assert.Throws<Exception>(func);
    }
}