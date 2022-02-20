using System;
using System.Globalization;
using System.Numerics;
using System.Collections.Generic;
using System.Text;

namespace ArrayObjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Product[] vect = new Product[n];

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Product { Name = name, Price = price};
            }
            double media = 0.0;
            for (int i = 0; i < n; i++)
            {
                media =+ vect[i].Price;
            }

            double soma = media / n;
            Console.WriteLine("Valor médio :" + soma.ToString("F2"), CultureInfo.InvariantCulture);
        }
    }
}
