using System;

class Insurance
{
  static void Main()
  {
    Console.WriteLine("What is your gender? (male/female)");
    string gender = Console.ReadLine();

    Console.WriteLine("How old are you?");
    string strAge = Console.ReadLine();
    int age = int.Parse(strAge);

    bool young = age < 26;
    bool male = gender == "male";

    if (young && male)
    {
      Console.WriteLine("Your insurance is going to be staggering!");
    }
    else if (young)
    {
      Console.WriteLine("Your insurance is going to be pricey.");
    }
    else if (male)
    {
      Console.WriteLine("meh, not too bad.");
    }
    else
    {
      Console.WriteLine("Insurance is expensive but yours is doable");
    }
  }
}
