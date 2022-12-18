using System;
internal class Program
{
  static void Main()
  {
    // find Even number between 1 to 50
    
    for(int i = 1; i <= 50; i++)
    {
      if(i % 2 == 0)
      {
        Console.WriteLine("{0} is even",i);
      }
    }
  }
}
