using Tyuiu.PavlovaVV.Sprint1.Task1.V11.Lib;
namespace Tyuiu.PavlovaVV.Sprint1.Task1.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнила: Павлова В. В. | ИСТНб-25-1";
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* Спринт #1                                                                         *");
            Console.WriteLine("* Тема: Создания итогового решения по спринту                                       *");
            Console.WriteLine("* Задание #1                                                                        *");
            Console.WriteLine("* Вариант #11                                                                       *");
            Console.WriteLine("* Выполнила: Павлова Валерия Викторовна | ИСТНб-25-1                                *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                          *");
            Console.WriteLine("* Написать  программу, которая запрашивает у пользователей исходные данные,         *");
            Console.WriteLine("* вычисляет результат по формуле 5 * x / (6 * y) и печатает его на экране.          *");                                
            Console.WriteLine("*                                                                                   *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                  *");
            Console.WriteLine("*************************************************************************************");
            double x, y;
            Console.WriteLine("Введите значение X:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение Y:");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                                         *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine(ds.Calculate(x, y));
            Console.ReadLine();
        }
    }
}
