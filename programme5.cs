using System;
internal class Program
{
  static void Main()
  {
    // find Roots of Quadratic Equations AX2+BX+C=0
    double x1, x2;
    Console.Write("A: ");
    double a = double.Parse(Console.ReadLine());

    Console.Write("B: ");
    double b = double.Parse(Console.ReadLine());

    Console.Write("C: ");
    double c = double.Parse(Console.ReadLine());

    double d = Math.Pow(b , 2) - 4 * a * c; // المميز

    if(d == 0)
    {
      Console.WriteLine("Roots of equation are real & equal!");
      x1 = x2 = -b / 2 * a;
      Console.WriteLine("X1 = x2 = {0}", x1);
    }
    else if(d > 0)
    {
      Console.WriteLine("Roots of equations are different!");
      x1 = (-b + Math.Sqrt(d)) / 2 * a;
      x2 = (-b - Math.Sqrt(d)) / 2 * a;
      Console.WriteLine("X1 = {0}", x1);
      Console.WriteLine("X2 = {0}", x2);
    }
    else
    {
      Console.WriteLine("Roots of equation are imaginary!");
    }
  }
}
