using System;
internal class Program
{
  static void Main()
  {
    // Convert temperature from Celsius to Fahrenheit
    Console.Write("Enter the temperature by celsius: ");
    double c = double.Parse(Console.ReadLine());

    double f = (1.8 * c) + 32;

    Console.WriteLine("{0} Celsius = {1} Fahrenheit", c, f);

  }
}
