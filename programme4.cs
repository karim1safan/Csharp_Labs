using System;
internal class Program
{
  static void Main()
  {
    // find the smallest of three numbers
    Console.Write("Enter the first num: ");
    double a = double.Parse(Console.ReadLine());

    Console.Write("Enter the second num: "); 
    double b = double.Parse(Console.ReadLine());

    Console.Write("Enter the third num: ");
    double c = double.Parse(Console.ReadLine());

    if(a < b && a < c)
    {
      Console.WriteLine("{0} the smallest",a);
    }
    else if(b < a && b < c)
    {
      Console.WriteLine("{0} the smallest", b);
    }
    else
    {
      Console.WriteLine("{0} the smallest", c);
    }
  }
}
