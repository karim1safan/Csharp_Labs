using System;
internal class Program
{
  static void Main()
  {
    // find Area & Perimeter of Triangle
    Console.Write("Enter the first side: "); 
    double a = double.Parse(Console.ReadLine());

    Console.Write("Enter the second side: ");
    double b = double.Parse(Console.ReadLine());

    Console.Write("Enter the third side: "); 
    double c = double.Parse(Console.ReadLine());

    if (a < 1 && b < 1 && c < 1)
    {
      Console.WriteLine("Pls Enter Positive Sides.");
      return; // to exist from programme
    }

    double s = (a + b + c) / 2.0; 
    double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
    double perimeter = a + b + c;

    Console.WriteLine("Area: {0} && perimeter: {1}", area, perimeter);
  }
}
