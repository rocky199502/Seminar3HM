using System;

namespace DZ1
{
    class Program
    {
        static int vvod ()
          {
             Console.WriteLine("Введите пятизначное число:");
             int number = int.Parse(Console.ReadLine());
             return number;
          }
  
       static void Polindrom (int number)
         {
             int reverse = 0;
             int numberNotReverse = number;
             while (numberNotReverse!= 0)
               {
                   reverse = 10 * reverse + numberNotReverse % 10;
                   numberNotReverse = numberNotReverse / 10;
               }
             if (number==reverse)
               {
                   Console.WriteLine("This is Polindrom!");
               }
            else Console.WriteLine("No, this is not Polindrom!");
         }
        static void Main(string[] args)
          {
              int number = vvod();
              Polindrom(number);
          }
    }
}
