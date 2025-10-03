using Tyuiu.PavlovaVV.Sprint1.Task7.V1.Lib;
namespace Tyuiu.PavlovaVV.Sprint1.Task7.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine();
            Console.WriteLine("Введите значение A:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение B:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение C:");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double z = ds.Calculate(a, b, c);
            Console.WriteLine(z);
            Console.ReadKey();
        }
    }
}
