using Tyuiu.PavlovaVV.Sprint1.Task6.V18.Lib;
namespace Tyuiu.PavlovaVV.Sprint1.Task6.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int res;

            if
                 (Int32.TryParse(Console.ReadLine(), out res))
                Console.WriteLine("* Введенная строка является символьным представлением натурального числа. *");
            else
                Console.WriteLine("* Введенная строка не является символьным представлением натурального числа. *");
            Console.ReadKey();
        }
    }
}
