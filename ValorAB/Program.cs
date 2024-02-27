using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValorAB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor de A: ");
            double A = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de B: ");
            double B = double.Parse(Console.ReadLine());

            double C = A;
            A = B;
            B = C;

            Console.WriteLine("O valor de A é: " + A);
            Console.ReadLine();

            Console.WriteLine("O valor de B é: " + B);
            Console.ReadLine();

            Console.ReadKey();
        }
    }
}
