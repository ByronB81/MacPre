using System;

class StartsWithZ
{
  static void Main()
  {
    Console.WriteLine("What is your name?");
    string userName = Console.ReadLine();
    if (userName.StartsWith("Z"))
    {
      Console.WriteLine("Your name starts with Z!");
    }
    else
    {
      Console.WriteLine("Your name does not start with a Z :(");
    }
  }
}
