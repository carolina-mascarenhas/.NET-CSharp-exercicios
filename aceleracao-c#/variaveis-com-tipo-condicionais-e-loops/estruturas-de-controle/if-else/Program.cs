public class Program
{
  public static int number;
  public static void Main()
  {
    if(number > 0)
    {
      Console.WriteLine("maior que zero");
    }
    else 
    {
      if(number < 0)
      {
        Console.WriteLine("menor que zero");
      }
      else
      {
        Console.WriteLine("igual a zero");
      }
    }
  }            
}