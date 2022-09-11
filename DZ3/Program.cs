using System;

namespace DZ3
{
    class Program
    {
        static int vvod ()
           {
              Console.Write("Введите число N: ");
              int N = int.Parse(Console.ReadLine());
              return N;
           }
        static void vivod(int number)
          {
              Console.Write("Таблица кубов от 1 до " + number+": ");
              for (int i = 1; i <= number;i++)
              {
                  Console.Write(Math.Pow(i,3));  
                  if (i != number)
                  {
                      Console.Write(",");  
                  }
             else Console.Write(";");  
              }
          }
        static void Main(string[] args)
        {
            int number = vvod();
            vivod(number);
        }
    }
}
