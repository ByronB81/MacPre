using System;

class Grade
{
  static void Main()
  {
    bool appRunning = true;
    while (appRunning)
    {
      Console.WriteLine("What grade did you get?");
      string grade = Console.ReadLine();
      if (grade.Contains("A")|| grade.Contains("B"))
      {
        Console.WriteLine("Well done!");
        appRunning = false;
      }
      else if (grade.Contains("C") || (grade.Contains("D")))
      {
        Console.WriteLine("You could do better");
        appRunning = false;
      }
      else if (grade.Contains("F"))
      {
        Console.WriteLine("You have failed.");
        appRunning = false;
      }
      else
      {
        Console.WriteLine("That answer is no recognized. Please enter A, B, C, D, E, or F.");
      }
    }
  }
}
