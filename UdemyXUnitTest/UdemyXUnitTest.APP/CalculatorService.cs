namespace UdemyXUnitTest.App
{
  public class CalculatorService : ICalculatorService
  {
    public int Add(int a, int b)
    {
      if (a == 0 || b == 0)
      {
        return 0;
      }

      return a + b;
    }

    public int Multip(int a, int b)
    {
      if (a == 0)
      {
        throw new System.Exception("a=0 olamaz.");
      }

      return a * b;
    }

  }
}
