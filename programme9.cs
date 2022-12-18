using System;
internal class Program
{
  static void Main()
  {
    // find if a number is prime or not
    Console.Write("Number: ");
    int n = int.Parse(Console.ReadLine());

    for(int i = 2; i < n ; i++)
      if(n % 2 == 0)
      {
        Console.WriteLine("{0} is not prime", n);
        return;
      }

    if(n == 1)
    {
      Console.WriteLine("1 is not a prime number");
      return;
    }

    Console.WriteLine("{0} is prime", n);   
  }
}
