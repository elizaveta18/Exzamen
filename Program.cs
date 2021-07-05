using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Экзамен
{
    class Program
    {
        static void Main(string[] args)
        {
            int otv = 1;
            while (otv != 0)
            {
                Console.WriteLine("Выберите задачу:");
                Console.WriteLine(" 1 - кртический путь.");
                int nom = Convert.ToInt32(Console.ReadLine());
                if (nom == 1)
                {
                    Class1 c1 = new Class1();
                    c1.Crt("Ввод.csv");
                }
                else
                {
                    Console.WriteLine("Неверный ввод!");
                }
                Console.WriteLine("Продолжить работу? да - 1, нет - 0");
                otv = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
            Console.ReadKey();
        }
    }
}
