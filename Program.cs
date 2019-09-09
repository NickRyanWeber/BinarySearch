using System;

namespace BinarySearch
{
  class Program
  {
    static void Main(string[] args)
    {
      var lower = 0m;
      var upper = 100m;
      //   var tries = 0;
      var success = false;

      while (!success)
      {
        var guess = Math.Floor((lower + upper) / 2);
        Console.WriteLine($"Is your number {guess}?");
        var input = Console.ReadLine();
        if (input == "y")
        {
          success = true;
        }
        else if (input == "higher")
        {
          lower = guess;
        }
        else if (input == "lower")
        {
          upper = guess;
        }
      }
    }
  }
}
