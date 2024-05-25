using SimpleCalc.Services;

namespace SimpleCalcTests;

public class CalcFeatureTest
{
    private CalcImplementation _calc = new CalcImplementation();

    [Theory]
    [InlineData(2, 2, 4)]
    [InlineData(4.5, 4.5, 9.0)]
    [InlineData(1, 3, 4)]
    public void Sum_TwoNumbers_MustReturnAExpectedNumber(int firstValue, int secondValue, int expectedResult)
    {
        // Arrange / Act
        int result = _calc.Add(firstValue, secondValue);

        // Assert
        Assert.Equal(expectedResult, result);
    }

    [Theory]
    [InlineData(2, 2, 4)]
    [InlineData(4.5, 4.5, 9.0)]
    [InlineData(1, 3, 4)]
    public void Sub_TwoNumbers_MustReturnAExpectedNumber(int firstValue, int secondValue, int expectedResult)
    {
        // Arrange / Act
        int result = _calc.Sub(firstValue, secondValue);

        // Assert
        Assert.Equal(expectedResult, result);
    }

    [Theory]
    [InlineData(9, 2, 18)]
    [InlineData(14.5, 2.0, 29.0)]
    [InlineData(12, -1, -12)]
    public void Multiply_TwoNumbers_MustReturnAExpectedNumber(int firstValue, int secondValue, int expectedResult)
    {
        // Arrange / Act
        int result = _calc.Multiply(firstValue, secondValue);

        // Assert
        Assert.Equal(expectedResult, result);
    }

    [Theory]
    [InlineData(12, 2, 6)]
    [InlineData(21.0, 2.0, 10.5)]
    public void Divide_TwoNumbers_MustReturnAExpectedNumber(int firstValue, int secondValue, int expectedResult)
    {
        // Arrange / Act
        int result = _calc.Divide(firstValue, secondValue);

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
    public void Calculate_FirstValuePowerSecondValue_MustReturnExpectedNumber(int firstValue, int secondValue, int expectedResult)
    {
        // Arrange / Act
        int result = _calc.Pow(basis: firstValue, exponent: secondValue);

        // Assert
        Assert.Equal(expectedResult, result);
    }

    [Theory]
    [InlineData(81, 9)]
    [InlineData(25, 5)]
    [InlineData(169, 13)]
    public void Calculate_SquareRootOfTheValue_MustReturnExpectedNumber(int value, int expectedResult)
    {
        // Arrange / Act
        int result = _calc.Root(value);

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