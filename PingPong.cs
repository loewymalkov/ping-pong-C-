using System;
using System.Collections.Generic;

class DoubleIt
{
  static void Main()
  {
  List<int> numberList = new List<int> {};
  List<string> pingList = new List<string> {};

  Console.WriteLine("Give me a number!");
  string input = Console.ReadLine();
  int userInput = int.Parse(input);
  for (int i = 1; i <= userInput; i++)
  {   
    if((i % 3 == 0) && (i % 5 == 0))
    {
      Console.WriteLine("Ping pong");
    }
     else if(i % 5 == 0)
    {
      Console.WriteLine("Pong");
    }
     else if(i % 3 == 0)
    {
      Console.WriteLine("Ping");
    }
    else
    {
       Console.WriteLine(i);
    }
  }
  }
}
