using System;
internal class Program
{
  static void Main()
  {
    // Write an if-statement that takes two integer variables and exchanges
    // their values if the first one is greater than the second one.
    int tmp, n1, n2;
    Console.Write("Num1: ");
    n1 = int.Parse(Console.ReadLine());
    Console.Write("Num2: ");
    n2 = int.Parse(Console.ReadLine());

    if(n1 > n2)
    {
      tmp = n1;
      n1 = n2;
      n2 = tmp;
    }

    Console.WriteLine("First number: {0} && Second number: {1}",n1,n2);
  }
}
