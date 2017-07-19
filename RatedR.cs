using System;

class RatedR
{
  static void Main()
  {
    Console.WriteLine("How old are you?");
    string strAge = Console.ReadLine();
    int intAge = int.Parse(strAge);

    if (intAge >= 17)
    {
      Console.WriteLine("You can see the movie!");
    }
    else
    {
      Console.WriteLine("I'm sorry but you are too young");
    }
  }
}
