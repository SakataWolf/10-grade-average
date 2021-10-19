using System;

namespace Média_de_10_notas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Média de 10 notas.\n");
            int x, n, m=0;

            for (x = 1; x <= 10; x++)
            {
                do
                {
                    Console.WriteLine("Digite a {0}ª Nota: ",x);
                    n = int.Parse(Console.ReadLine());
                    if (n < 0 || n > 10)
                    {
                        Console.WriteLine("Valor não valido");
                    }
                } while (n < 0 || n > 10);
                m = m + n;
            }
            Console.WriteLine("\n\nMédia final do aluno é: " + m / 10);
        }
    }
}
