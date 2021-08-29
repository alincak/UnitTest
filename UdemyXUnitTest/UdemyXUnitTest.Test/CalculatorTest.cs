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
  }
}
