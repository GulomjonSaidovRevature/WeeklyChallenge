using System;

namespace WeeklyChallenge
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(UniqueFract());

      Console.WriteLine(Collatz(4));
      Console.WriteLine(Collatz(11));
      Console.WriteLine(Collatz(14));
    }

    /// <summary>
    /// This method calculates the sum of irreducible fractions between 0 and 1
    /// </summary>
    /// <returns></returns>
    public static double UniqueFract()
    {
      double sum = 0d;
      for (int denominator = 2; denominator < 10; denominator++)
      {
        for (int numerator = 1; numerator < denominator; numerator++)
        {
          // if numerator is 1, we add the fraction to the sum definitely
          if (numerator == 1)
          {
            Console.WriteLine($"{numerator}/{denominator}");
            sum += (double)numerator / (double)denominator;
          }
          // if numerator is not 1, first we check if denominator is not divisible by numerator
          else if (denominator % numerator != 0)
          {
            bool condition = true;
            // then we check if numerator and denominator have common divisors
            for (int a = 2; a <= numerator; a++)
            {
              if ((numerator % a == 0) & (denominator % a == 0))
              {
                condition = false;
              }

            }
            // finally, we the above two conditions are met, we can add the fraction to the sum.
            if (condition)
            {
              Console.WriteLine($"{numerator}/{denominator}");
              sum += (double)numerator / (double)denominator;
            }
          }
        }
      }
      return sum;
    } // end of UniqueFract() method

    /// <summary>
    /// This method evaluates operations below, until reaching 1. Return the number of steps it took.
    /// </summary>
    /// operations:
    ///- If n is even -> n / 2
    ///- If n is odd -> n* 3 + 1
    /// <param name="n"></param>
    /// <returns></returns>
    public static int Collatz(int n)
    {
      int steps = 0;
      while (n > 1)
      {
        steps++;
        if (n % 2 == 0)
        {
          n = n / 2;
        }
        else
        {
          n = n * 3 + 1;
        }
      }
      return steps;
    }

  }// end of class
}// end of namespace
