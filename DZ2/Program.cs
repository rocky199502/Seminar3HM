using System;

namespace DZ2
{
    class Program
    {
        static void firstVvod (out double firstX, out double firstY, out double firstZ)
          {
             Console.WriteLine("Введите координату X первой точки:");
             firstX = double.Parse(Console.ReadLine());
             Console.WriteLine("Введите координату Y первой точки:");
             firstY = double.Parse(Console.ReadLine());
             Console.WriteLine("Введите координату Z первой точки:");
             firstZ = double.Parse(Console.ReadLine());
         }
  
        static void secondVvod (out double secondX, out double secondY, out double secondZ)
         {
            Console.WriteLine("Введите координату X второй точки:");
            secondX = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату Y второй точки:");
            secondY = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату Z второй точки:");
            secondZ = double.Parse(Console.ReadLine());
         }
        static double Distan(double X1, double X2,double Y1, double Y2,double Z1, double Z2)
         {
            double result = Math.Sqrt(Math.Pow((X2-X1),2)+Math.Pow((Y2-Y1),2)+Math.Pow((Z2-Z1),2));   
            return result;
         }
        static void Main(string[] args)
        {
            double X1 = 0;
            double Y1 = 0;
            double Z1 = 0;
            double X2 = 0;
            double Y2 = 0;
            double Z2 = 0;
            firstVvod(out X1,out Y1, out Z1);
            secondVvod(out X2,out Y2, out Z2);
            double distantBetweenPoint=Distan(X1,X2,Y1,Y2,Z1,Z2);
            Console.WriteLine("Расстояние между точками = "+distantBetweenPoint);
        }
    }
}
