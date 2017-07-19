using System;

class GreaterNow
{
  static void Main()
  {
    Console.WriteLine("Enter a number");
    string strNum = Console.ReadLine();
    int intNum = int.Parse(strNum);
    if (intNum >= 0)
    {
      Console.WriteLine("Ah, a number that is zero or greater... allow me to add 1");
      intNum = intNum + 1;
    }
    else
    {
      Console.WriteLine("So less than zero... allow me to subtract 1");
      intNum = intNum - 1;
    }
    string result = intNum.ToString();
    Console.WriteLine("You number is now " + result);
  }
}
