using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {

            string x;
            int y;
            double a;

            string[] vet = Console.ReadLine()!.Split(' ');

            x = vet[0];
            y = int.Parse(vet[1]);
            a = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine(x);
            Console.WriteLine(y);  
            Console.WriteLine(a.ToString("F2", CultureInfo.InvariantCulture)); 

            Console.ReadLine();

        }
    }
}