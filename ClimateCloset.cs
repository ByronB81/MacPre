using System;

class ClimateCloset
{
  static void Main()
  {
    Console.WriteLine("What is the temperature in degrees farenheit");
    string strNum = Console.ReadLine();
    int temp = int.Parse(strNum);
    if (temp > 90)
    {
      Console.WriteLine("Warm out there. Dress light!");
    }
    else if (temp < 65)
    {
      Console.WriteLine("Brrr, chilly outside. Bundle up!");
    }
    else
    {
      Console.WriteLine("Nice day out, wear whatever makes you happy :)");
    }
  }
}
