using System;

namespace AWholeNewWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      var min = 1;
      var max = 100;
      var Input = "";
      Console.WriteLine("What is your favorite number between 1 and 100?");
      while (Input != "yes")
      {
        var Guess = ((min + max) / 2);

        Console.WriteLine($"Is your number {Guess}?");
        Input = Console.ReadLine();

        if (Input == "no")
        {
          Console.WriteLine("Is your number higher or lower?");
          Input = Console.ReadLine();
          if (Input == "higher")
          {
            min = Guess;
          }
          else if (Input == "lower")
          {
            max = Guess;
          }
        }
      }

      Console.WriteLine("Woohoo!!!");
    }
  }
}

