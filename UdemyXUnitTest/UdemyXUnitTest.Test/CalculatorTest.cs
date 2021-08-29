using System.Collections.Generic;
using UdemyXUnitTest.App;
using Xunit;

namespace UdemyXUnitTest.Test
{
  public class CalculatorTest
  {
    private Calculator _calculator;

    public CalculatorTest()
    {
      _calculator = new Calculator();
    }

    [Fact]
    public void AddTest()
    {
      //arrange
      int a = 5;
      int b = 20;

      //act
      var total = _calculator.Add(a, b);

      //assert
      Assert.Equal(25, total);
    }

    [Fact]
    public void AssertExamplesTest()
    {
      //var names = new List<string>() { "Fatih", "Emre", "Hasan" };
      //Assert.Contains(names, x => x == "Fatih");

      //Assert.Contains("hikaye", "Size bir hikayem var");
      //Assert.DoesNotContain("hikayesi", "Size bir hikayem var");

      //var regex = "^kedi";
      //Assert.Matches(regex, "kedi çok tatlı :)");

      //Assert.InRange(10, 2, 20);

      Assert.IsAssignableFrom<double>(20.10);
    }

    [Theory]
    [InlineData(2, 5, 7)]
    [InlineData(10, 5, 15)]
    [InlineData(2, 10, 12)]
    [InlineData(9, 8, 17)]
    public void AddTest2(int a, int b, int expectedTotal)
    {
      //act
      var actTotal = _calculator.Add(a, b);

      //assert
      Assert.Equal(expectedTotal, actTotal);
    }

  }
}
