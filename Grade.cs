using System;

class Grade
{
  static void Main()
  {
    Console.WriteLine("What grade did you get?");
    string grade = Console.ReadLine();
    if (grade.Contains("A")|| grade.Contains("B"))
    {
      Console.WriteLine("Well done!");
    }
    else if (grade.Contains("C") || (grade.Contains("D")))
    {
      Console.WriteLine("You could do better");
    }
    else
    {
      Console.WriteLine("That is unacceptable");
    }
  }
}
