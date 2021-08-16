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
      int part = (value - value % 10) / 10;
      return SumNumbers(part) + 
    }
    static void Main(string[] args)
    {
    }
  }
}
