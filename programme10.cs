using System;
internal class Program
{
  static void Main()
  {
    // find sum and average of given series of numbers
    Console.Write("Number: ");
    int n = int.Parse(Console.ReadLine());

    int sum = 0;
    for(int i = 0; i <= n; i++)
    {
      sum = sum + i;
    }
    double avg = sum / n;
    Console.WriteLine("Sum: {0} && Avg: {1}",sum,avg);    
  }
}
