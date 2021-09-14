namespace UdemyXUnitTest.App
{
  public class Calculator
  {
    private readonly ICalculatorService _calculatorService;

    public Calculator(ICalculatorService calculatorService)
    {
      _calculatorService = calculatorService;
    }

    public int Add(int a, int b)
    {
      return _calculatorService.Add(a, b);
    }
  }
}
