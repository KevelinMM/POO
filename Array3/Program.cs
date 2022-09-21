/*Pra rodar: dotnet run --project Array3
Kevelin Mondadori Mattos

Faça um programa que leia N números inteiros e armazene-os em
um vetor.
Em seguida, mostre na tela: todos os números pares e a quantidade de números pares
*/


class Program
{
    Program()
    {
        //Variaveis
        int n;
        Console.Write("Digite o numero de valores que voce deseja:");
        n = int.Parse(Console.ReadLine());
        int[] numeros = new int[n];
        int numerospares = 0;

        //Leitura e armazenameno
        for (int i = 0; i < n; i++)
        {
            Console.Write("Digite o numero {0}: ", i);
            numeros[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("");
        Console.WriteLine("São pares: ");

        foreach (int numero in numeros)
        {
            if (numero % 2 == 0)
            {
                Console.WriteLine("{0}", numero);
                numerospares++;
            }
        }


        Console.WriteLine("");
        Console.WriteLine("Quantidade de numeros pares: {0}", numerospares);

        //uso de FOREACH - percorre valores e realiza calculo 

    }
    static void Main(string[] args)
    {
        new Program();
    }
}
