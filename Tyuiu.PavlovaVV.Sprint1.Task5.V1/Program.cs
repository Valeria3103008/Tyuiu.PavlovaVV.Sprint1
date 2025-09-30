using Tyuiu.PavlovaVV.Sprint1.Task5.V1.Lib;
namespace Tyuiu.PavlovaVV.Sprint1.Task5.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                 *");
            Console.WriteLine("****************************************************");

            Console.WriteLine("Введите значение x1:");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение y1:");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение x2:");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение y2:");
            double y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("****************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                       *");
            Console.WriteLine("****************************************************");

            int res = Convert.ToInt32(ds.DistanceBetweenDots(x1, y1, x2, y2));
            Console.WriteLine(res);

            Console.ReadKey();

        }
    }
}
