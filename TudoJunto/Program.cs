using System;
namespace ExemploBreakProblema
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroQuestao = 9;
            while (numeroQuestao != 0)
            {


                Console.Write("Informe o valor do exercicio:\n");
                Console.Write("1 - O primeiro número divisível por 11, 13 e 17 a partir do número informado\n");
                Console.Write("2 - Informa se o valor informado é maior ou menor que 10\n");
                Console.Write("3 - Informa a fase da vida com relação a idade informada\n");
                Console.Write("4 - Inverte os valores informados\n");
                Console.Write("5 - (n1 + n2) * n1 é\n");
                Console.Write("0 - Sair\n");

                //Pessoa digita e cai na variavel nQuestao
                string nQuestao = Console.ReadLine();
                //Converte string pra int
                numeroQuestao = int.Parse(nQuestao);

                switch (numeroQuestao)
                {

                    case 1:
                        //Exericio 1
                        Console.Write("Informe um valor:");
                        string apartir = Console.ReadLine();
                        int v1 = int.Parse(apartir);
                        Console.WriteLine("O primeiro número divisível por 11, 13 e 17 a partir do " + v1 + " eh: " + Break(v1));
                        break;

                    case 2:
                        //Exericio 2
                        Console.Write("Informe um valor:");
                        string auxValor = Console.ReadLine();
                        int valor = int.Parse(auxValor);
                        Console.WriteLine(Ternario(valor));
                        break;

                    case 3:
                        //Exericio 3
                        Console.Write("Informe sua idade:");
                        String idade = Console.ReadLine();
                        byte resposta = byte.Parse(idade);
                        Console.WriteLine(Idade(resposta));
                        break;

                    case 4:
                        //Exericio 4
                        Console.Write("Informe numero A: ");
                        string ta = Console.ReadLine();
                        Console.Write("Informe numero B: ");
                        string tb = Console.ReadLine();

                        int a = int.Parse(ta);
                        int b = int.Parse(tb);
                        Console.WriteLine(InverterValores(a, b));
                        break;

                    case 5:
                        //Exercicio 5
                        float n1, n2;
                        Console.Write(" Digite o primeiro numero : ");
                        string numero1 = Console.ReadLine();

                        Console.Write(" Digite o segundo numero : ");
                        string numero2 = Console.ReadLine();

                        n1 = float.Parse(numero1);
                        n2 = float.Parse(numero2);
                        Console.WriteLine("(n1 + n2 ) * n1 é igual a: " + NumerosSoma(n1, n2));
                        break;
                }
            }
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

        //Exericio 4
        public static string InverterValores(int a, int b)
        {
            a += b;
            b = a - b;
            a -= b;
            string x = "a:" + a.ToString() + " - b:" + b.ToString();
            return x;

        }
        //Exericio 5
        public static float NumerosSoma(float n1, float n2)
        {
            float total = (n1 + n2) * n1;
            return total;

        }

    }
}