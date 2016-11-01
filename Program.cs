using System;
using System.Collections.Generic;
using System.Linq;

namespace MinMaxN
{
    class Program
    {
        static void Main(string[] args)
        {
            var values = new List<int>();
            Console.WriteLine("Введите количество чисел");

            string n = Console.ReadLine();

            int j = int.Parse(n);

            for (int i = 1; i <= j; i++)
            {

                Console.WriteLine("Введите {0} число.", i);
                values.Add(int.Parse( Console.ReadLine()));
            }


            foreach (var item in values)
            {
                               
            }
            Console.WriteLine("Наибольшее число {0}", values.Max());
            Console.WriteLine("Нименьшее число {0}", values.Min());

            Console.ReadKey();
        }
    }
}
