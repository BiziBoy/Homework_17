using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//рекурсивный метод, который находит сумму цифр в числе
namespace Homework_17
{
  class Program
  {
    static int SumNumbers(int value)
    {
      if (value < 10)
      {
        return value;
      }
      return SumNumbers((value - value % 10) / 10) + value % 10;
    }

    static void Main(string[] args)
    {
      Console.Write("Введите число, у которого будет найдена сумма цифр: ");
      int a = int.Parse(Console.ReadLine());
      Console.WriteLine($"Сумма цифр числа {a}: {SumNumbers(a)} ");
      Console.ReadLine();
    }
  }
}
