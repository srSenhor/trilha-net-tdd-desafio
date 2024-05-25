using SimpleCalc.Services;

namespace SimpleCalcTests;

public class CalcFeatureTest
{
    private CalcImplementation _calc = new CalcImplementation();

    [Theory]
    [InlineData(2, 2, 4)]
    [InlineData(1, 3, 4)]
    public void Sum_TwoIntegerNumbers_MustReturnAExpectedNumber(int firstValue, int secondValue, int expectedResult)
    {
        // Arrange / Act
        int result = _calc.Add(firstValue, secondValue);

        // Assert
        Assert.Equal(expectedResult, result);
    }

    [Theory]
    [InlineData(1.3, 2.7, 4.0)]
    [InlineData(4.5, 4.5, 9.0)]
    public void Sum_TwoDoubleNumbers_MustReturnAExpectedNumber(double firstValue, double secondValue, double expectedResult)
    {
        // Arrange / Act
        double result = _calc.Add(firstValue, secondValue);

        // Assert
        Assert.Equal(expectedResult, result);
    }


    [Theory]
    [InlineData(2, 2, 0)]
    [InlineData(1, 3, -2)]
    public void Sub_TwoIntegerNumbers_MustReturnAExpectedNumber(int firstValue, int secondValue, int expectedResult)
    {
        // Arrange / Act
        int result = _calc.Sub(firstValue, secondValue);

        // Assert
        Assert.Equal(expectedResult, result);
    }

    [Theory]
    [InlineData(5.5, 5.0, .5)]
    [InlineData(4.5, 4.5, 0.0)]
    public void Sub_TwoDoubleNumbers_MustReturnAExpectedNumber(double firstValue, double secondValue, double expectedResult)
    {
        // Arrange / Act
        double result = _calc.Sub(firstValue, secondValue);

        // Assert
        Assert.Equal(expectedResult, result);
    }

    [Theory]
    [InlineData(9, 2, 18)]
    [InlineData(12, -1, -12)]
    public void Multiply_TwoIntegerNumbers_MustReturnAExpectedNumber(int firstValue, int secondValue, int expectedResult)
    {
        // Arrange / Act
        int result = _calc.Multiply(firstValue, secondValue);

        // Assert
        Assert.Equal(expectedResult, result);
    }

    [Theory]
    [InlineData(9.0, -2.5, -22.5)]
    [InlineData(14.5, 2.0, 29.0)]
    public void Multiply_TwoDoubleNumbers_MustReturnAExpectedNumber(double firstValue, double secondValue, double expectedResult)
    {
        // Arrange / Act
        double result = _calc.Multiply(firstValue, secondValue);

        // Assert
        Assert.Equal(expectedResult, result);
    }

    [Theory]
    [InlineData(12, 2, 6)]
    [InlineData(-21, -3, 7)]
    public void Divide_TwoIntegerNumbers_MustReturnAExpectedNumber(int firstValue, int secondValue, double expectedResult)
    {
        // Arrange / Act
        double result = _calc.Divide(firstValue, secondValue);

        // Assert
        Assert.Equal(expectedResult, result);
    }

    [Theory]
    [InlineData(95.0, 2.0, 47.5)]
    [InlineData(21.0, -2.0, -10.5)]
    public void Divide_TwoDoubleNumbers_MustReturnAExpectedNumber(double firstValue, double secondValue, double expectedResult)
    {
        // Arrange / Act
        double result = _calc.Divide(firstValue, secondValue);

        // Assert
        Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void Divide_ANumberByZero_MustThrowAnException()
    {
        // Arrange / Act / Assert
        Assert.Throws<DivideByZeroException>(() => _calc.Divide(20, 0));
    }

    [Theory]
    [InlineData(2, 3, 8)]
    [InlineData(3, 4, 81)]
    [InlineData(5, 2, 25)]
    public void Calculate_FirstValuePowerSecondValue_MustReturnExpectedNumber(double firstValue, double secondValue, double expectedResult)
    {
        // Arrange / Act
        double result = _calc.Pow(basis: firstValue, exponent: secondValue);

        // Assert
        Assert.Equal(expectedResult, result);
    }

    [Theory]
    [InlineData(81.0, 9.0)]
    [InlineData(25.0, 5.0)]
    [InlineData(169.0, 13.0)]
    public void Calculate_SquareRootOfTheValue_MustReturnExpectedNumber(double value, double expectedResult)
    {
        // Arrange / Act
        double result = _calc.Root(value);

        // Assert
        Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void Calculate_SquareRootOfANegativeValue_MustThrowException()
    {
        // Arrange / Act / Assert
        Assert.Throws<ArithmeticException>(() => _calc.Root(-25));
    }

    [Fact]
    public void Show_OperationHistory_MustReturn5LastOperations()
    {
        // Arrange / Act
        var history = _calc.History();

        // Assert
        Assert.NotEmpty(history);
        Assert.Equal(5, history.Count);
    }
    
}