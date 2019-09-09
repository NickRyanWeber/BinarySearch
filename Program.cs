using System;

namespace BinarySearch
{
  class Program
  {
    static void Main(string[] args)
    {
      var lower = 0m;
      var upper = 100m;
      var guess = Math.Floor((lower + upper) / 2);
      //   var tries = 0;
      var success = false;

      Console.Write("Welcome to ");
      Console.ForegroundColor = ConsoleColor.Red;
      Console.Write("Number Guesser! ");
      Console.ResetColor();
      Console.WriteLine("The game where the computer guesses a number you pick.");
      System.Threading.Thread.Sleep(2000);
      Console.WriteLine("In order to play, you need to understand the rules...");
      System.Threading.Thread.Sleep(1000);
      Console.ForegroundColor = ConsoleColor.Red;
      Console.Write("FIRST,");
      Console.ResetColor();
      Console.Write(" pick a number between ");
      Console.ForegroundColor = ConsoleColor.Green;
      Console.Write(lower);
      Console.ResetColor();
      Console.Write(" & ");
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine(upper);
      Console.ResetColor();
      System.Threading.Thread.Sleep(1000);
      Console.Write("If your number is guessed, type ");
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("YES");
      Console.ResetColor();
      System.Threading.Thread.Sleep(1000);
      Console.Write("If your number higher than the guess, type ");
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("HIGHER");
      Console.ResetColor();
      System.Threading.Thread.Sleep(1000);
      Console.Write("If your number lower than the guess, type ");
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("LOWER");
      Console.ResetColor();
      System.Threading.Thread.Sleep(1000);
      Console.Write("READY");
      System.Threading.Thread.Sleep(250);
      Console.Write(".");
      System.Threading.Thread.Sleep(250);
      Console.Write(".");
      System.Threading.Thread.Sleep(250);
      Console.Write(".");
      System.Threading.Thread.Sleep(250);
      Console.Write("?");
      System.Threading.Thread.Sleep(250);
      Console.Write("?");
      System.Threading.Thread.Sleep(250);
      Console.WriteLine("?");
      Console.WriteLine("");

      while (!success)
      {
        Console.Write("Is your number ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{guess}?");
        Console.ResetColor();
        var input = Console.ReadLine();
        if (input.ToLower() == "y" || input.ToLower() == "yes")
        {
          Console.WriteLine("Do you want to play again? Y/N");
          var input2 = Console.ReadLine();
          if (input2.ToLower() == "y" || input2.ToLower() == "yes")
          {
            upper = 100;
            lower = 0;
          }
          else if (input2.ToLower() == "n" || input2.ToLower() == "no")
          {
            success = true;
          }
          else
          {
            Console.WriteLine("Hmmm...I don't recognize that response, please try again");
            Console.WriteLine("Do you want to play again? Y/N");
          }
        }
        else if (input.ToLower() == "higher" || input.ToLower() == "h")
        {
          if (guess == lower || guess == upper)
          {
            Console.WriteLine($"Don't lie, I know your number is {guess}");
          }
          else
          {
            lower = guess;
            guess = Math.Ceiling((lower + upper) / 2);
          }
        }
        else if (input.ToLower() == "lower" || input.ToLower() == "l")
        {
          if (upper == guess || lower == guess)
          {
            Console.WriteLine($"Don't lie, I know your number is {guess}");
          }
          else
          {
            upper = guess;
            guess = Math.Floor((lower + upper) / 2);
          }
        }
        else
        {
          Console.WriteLine("Hmmm...I don't recognize that response, please try again");
        }
      }
    }
  }
}
