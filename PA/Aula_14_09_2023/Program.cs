using System;

namespace Aula_14_09_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal n1, n2, n3, n4 ,somatoria, media;

            Console.WriteLine("Informe a nota 01: ");
            n1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Informe a nota 02: ");
            n2 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Informe a nota 03: ");
            n3 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Informe a nota 04: ");
            n4 = decimal.Parse(Console.ReadLine());

            somatoria = n1 + n2 + n3 + n4;

                media = somatoria / 4;

            Console.Write("A média final é de: "  + media );

        }
    }
}
