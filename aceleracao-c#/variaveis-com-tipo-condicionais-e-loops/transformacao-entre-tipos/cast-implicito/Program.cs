// public class Program
// {
//   public static void Main()
//   {        
//     int someIntNumber = 51;
//     long longlNumberCast = someIntNumber;

//     Console.WriteLine(longlNumberCast);
//   }            
// }

// public class Program
// {
//   public static void Main()
//   {        
//     int intResult = 5/2;

//     Console.WriteLine(intResult);
//   }            
// }

// public class Program
// {
//   public static void Main()
//   {        
//     long someLongNumber = 516144066604654;
//     int intNumber = (int) someLongNumber;

//     Console.WriteLine(intNumber);
//   }            
// }

// public class Program
// {
//   public static void Main()
//   {
//     long someLongNumber = 42;
//     int intNumber = Convert.ToInt32(someLongNumber);

//     Console.WriteLine(intNumber);
//   }
// }

// public class Program
// {
//   public static void Main()
//   {        
//     string someString = "42";
//     int convertInt = Convert.ToInt32(someString);

//     Console.WriteLine(convertInt);
//   }            
// }

// public class Program
// {
//   public static void Main()
//   {        
//     string someString = "2022";
//     Console.WriteLine(someString is string);

//     int convertInt = Convert.ToInt32(someString);
//     Console.WriteLine(convertInt is int);
//   }            
// }

public class Program
{
  public static void Main()
  {        
    string someString = "20";
    int number = 0;
    
    if(someString is string)
    {
      number = Convert.ToInt32(someString);
      Console.WriteLine(number);
    }
  }
}