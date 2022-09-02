public class Program
{
  public static int number;
  public static void Main()
  {
    switch (number)
    {                
      case > 0:
        Console.WriteLine("maior que 0");
        break;               
      case 0:
        Console.WriteLine("igual a zero");
        break;
      default:                    
        Console.WriteLine("menor que zero");
        break;
    }
  }            
}