using System.Diagnostics.CodeAnalysis;
using Demo.Sales.Facade.Services;

namespace Demo.Sales.Tests;

[ExcludeFromCodeCoverage]
public class UnitTest1
{
    [Theory]
    [InlineData(5, 6, 11)]
    [InlineData(2, 3, 5)]
    public void SimpleTest(int addendo1, int addendo2, int result)
    {
        // 
        var somma = SalesOrderFacade.Somma(addendo1, addendo2);
        
        // Assert
        Assert.Equal(result, somma);
    }

    [Fact]
    public void FizzBuzzTest()
    {
        // Multiplo di 3 => Fizz
        // Multiplo di 5 => Buzz
        // Multiplo di 3 e 5 => FizzBuzz

        var fizzBuzz = "";
        for (var i = 1; i <= 15; i++)
        {
            fizzBuzz += SalesOrderFacade.FizzBuzz(i);
            Console.WriteLine(fizzBuzz);
        }
        
        Assert.Equal("12Fizz4BuzzFizz78FizzBuzz11Fizz1314FizzBuzz", fizzBuzz);
    }
}