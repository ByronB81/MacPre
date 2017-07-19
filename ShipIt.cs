using System;

class ShipIt
{
  static void Main()
  {
    Console.WriteLine("Enter weight in lbs.");
    string strWeight = Console.ReadLine();
    int intWeight = int.Parse(strWeight);
    Console.WriteLine("Enter distance in miles");
    string strDistance = Console.ReadLine();
    int intDistance = int.Parse(strDistance);
    int finalResult = TotalPrice(intWeight, intDistance);
    Console.WriteLine(finalResult);

  }

  static int TotalPrice(int weightNum, int distanceNum)
  {
    int result = (weightNum / 2) + (distanceNum / 5);
    Console.WriteLine("hmmm");
    return result;
  }
}
