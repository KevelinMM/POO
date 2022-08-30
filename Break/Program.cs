using System;
namespace ExemploBreakProblema
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 1000000; i++)
            {
                if ((i % 11 == 0) && (i % 13 == 0) && (i % 17 == 0))
                {
                    Console.WriteLine("O primeiro número divisível por 11, 13 e 17 eh: " + i);
                    break;
                }
            }
        }
    }
}