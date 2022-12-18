using System;
internal class Program
{
  static void Main()
  {
    // find sum of series 1+2+3+…..+N
    Console.Write("Number: ");
    int n = int.Parse(Console.ReadLine()); // 10

    int sum = 0;
    for(int i = 0; i <= n; i++)
    {
      sum = sum + i;
    }

    Console.WriteLine("Sum: {0}",sum);
  }
}
