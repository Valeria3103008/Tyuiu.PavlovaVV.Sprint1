using System;
using Tyuiu.PavlovaVV.Sprint1.Task2.V27.Lib;
namespace Tyuiu.PavlovaVV.Sprint1.Task2.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            int x;

            Console.WriteLine("Введите значение X:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Квадрат числа X = " + ds.CalculateSquarePerimetr(x));

            Console.ReadLine();
        }
    }
}
