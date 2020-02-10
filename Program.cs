using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("What is your name?");
      var fullName = Console.ReadLine();
      Console.WriteLine("Hello, World, my name is " + fullName);
    }
  }
}
