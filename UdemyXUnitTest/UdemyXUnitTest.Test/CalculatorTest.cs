using System.Collections.Generic;
using UdemyXUnitTest.App;
using Xunit;

namespace UdemyXUnitTest.Test
{
  public class CalculatorTest
  {
    [Fact]
    public void AddTest()
    {
      //arrange
      int a = 5;
      int b = 20;
      var calculator = new Calculator();

      //act
      var total = calculator.Add(a, b);

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

  }
}
