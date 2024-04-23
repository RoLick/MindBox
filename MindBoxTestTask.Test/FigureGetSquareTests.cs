using MindBoxTestTask.Extension;
using MindBoxTestTask.Figure;
using MindBoxTestTask.Figure.Abstraction;

namespace MindBoxTestTask.Test;

public class FigureGetSquareTests
{
    [Theory]
    [InlineData(1.0, Math.PI)]
    [InlineData(2.1, 13.8474)]
    public void CircleGetSquareTests(double radius, double output)
    {
        //Arrange
        IFigure figure = new Circle(radius);
        
        //Act
        var result = figure.GetSquare();
        
        //Assert
        Assert.True(result.EqualsWithTolerance(output));
    }
}