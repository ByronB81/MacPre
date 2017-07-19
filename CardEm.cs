using System;

class CardEm
{
  static void Main()
  {
    Console.WriteLine("What is your age?");
    string strAge = Console.ReadLine();
    int intAge = int.Parse(strAge);
    if (intAge >= 21)
    {
      Console.WriteLine("You are old enough to drink!");
    }
    else
    {
      Console.WriteLine("Sorry, too young to drink.");
    }
  }
}
