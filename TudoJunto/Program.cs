using System;
namespace ExemploBreakProblema
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exericio 1
            Console.WriteLine(Break(2432));

            //Exericio 2
            Console.Write("Informe um valor:");
            string auxValor = Console.ReadLine();
            int valor = int.Parse(auxValor);
            Console.WriteLine(Ternario(valor));

            //Exericio 3
            Console.Write("Informe sua idade:");
            String idade = Console.ReadLine();
            byte resposta = byte.Parse(idade);
            Console.WriteLine(Idade(resposta));
        }

        //Exericio 1
        public static int Break(int x)
        {
            for (int i = x; i <= 1000000; i++)
            {
                if ((i % 11 == 0) && (i % 13 == 0) && (i % 17 == 0))
                {
                    return i;
                }
            }
            return 0;
        }

        //Exericio 2
        public static string Ternario(int x)
        {
            return (x >= 10) ? "Maior/igual a dez!" : "Menor que dez!";
        }

        //Exericio 3
        public static string Idade(int x)
        {

            if (x <= 12)
            {
                return ("Uma criança!");
            }
            else if (x > 12 && x < 18)
            {
                return ("Um adolescente!");
            }
            else
            {
                return ("Um adulto!!");
            }
        }

    }
}