using System;

class TwoDigits
{
  static void Main()
  {
    Console.WriteLine("Enter a number");
    string strNum = Console.ReadLine();
    int intNum = int.Parse(strNum);
    if (intNum > 9 && intNum < 100)
    {
      Console.WriteLine("This is a double digit number!");
    }
    else
    {
      Console.WriteLine("Get that non-double digit ish outta here");
    }
  }
}
