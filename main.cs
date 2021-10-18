using System;
using System.Linq;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("Odd and Even Numbers");
    double[] inputNumbers = new double[10];
    Console.WriteLine("Enter 10 Numbers");

    for (int i = 0; i<10; i++)
    {
      inputNumbers[i] = Convert.ToDouble(Console.ReadLine());
    }
    Console.WriteLine("The numbers you entered are");

    for (int i = 0; i<10; i++)
    {
      Console.WriteLine("{0}", inputNumbers[i]);
    }
    double[] OddNumber = new double[10];
    double[] EvenNumber = new double[10];

    for (int i = 0; i<10; i++)
    {
      double mod = inputNumbers[i];
      if (mod%2==0)
      {
        EvenNumber[i] = inputNumbers[i];
      }
      else
      {
        OddNumber[i] = inputNumbers[i];
      }
    }
    Console.WriteLine("Odd numbers in descending order");
    Array.Sort(OddNumber);
    Array.Reverse(OddNumber);

    for (int i = 0;i<OddNumber.Length;i++)
    {
      Console.WriteLine("{0}",OddNumber[i]);
    }

    Console.WriteLine("Even numbers in ascending order");
    Array.Sort(EvenNumber);

    for (int i = 0;i<EvenNumber.Length;i++)
    {
      Console.WriteLine("{0}",EvenNumber[i]);
    }
    }
  }