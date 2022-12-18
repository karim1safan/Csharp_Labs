using System;
internal class Program
{
  static void Main()
  {
    // find the factorial of number
    Console.Write("Number: ");
    int n = int.Parse(Console.ReadLine());

    int fact = 1;
    for(int i = 1; i <= n; i++)
    {
      fact = fact * i;
    }

    Console.WriteLine("{0}! = {1}",n,fact);
  }
}
