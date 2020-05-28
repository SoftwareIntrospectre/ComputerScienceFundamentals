using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        Factorial_RegularRecursion(50);
        // Factorial_TailRecursion(50);
    }

    static BigInteger Factorial_RegularRecursion(BigInteger n)
    {

        //base case
        if(n == 0)
        {
            return 1;
        }

        n = n * Factorial_RegularRecursion(n - 1);
        Console.WriteLine(n);
        return n;
    }
}

