﻿// namespace variable;
// public class Class1
// {
//   public string someString = "oi";
// }

// namespace variable;
// public class Class1
// {
//   public int intEntry = 42;
//   public double doubleResponse;

//   public void Transform()
//   {
//     doubleResponse = (double) intEntry;
//   }
// }

namespace variable;
public class Class1
{
  public string strEntry = "42";
  public int intResponse;

  public void DoConversion()
  {
    if(strEntry is string)
    {
      intResponse = Convert.ToInt32(strEntry);
    }
  }
}