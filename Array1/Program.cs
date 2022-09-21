/*Pra rodar: dotnet run --project Array1
Solicite para o usuário digitar 10 números e os armazene em um
array.

Após estar com os valores armazenados no primeiro array, calcule
a média dos seus elementos e monte um segundo array com os
valores do primeiro array multiplicado por sua média.

Ao final mostre os valores dos dois arrays.
*/


//Kevelin Mondadori Mattos
class Program
{
    Program()
    {
        //Variaveis
        int n;
        decimal soma = default;
        decimal[] numeros;
        decimal[] multiplica;

        // cria o array com a quantidade de posições indicada
        numeros = new decimal[10];
        multiplica = new decimal[10];

        //Leitura e armazenameno
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write("Digite o {0} valor: ", i);
            numeros[i] = decimal.Parse(Console.ReadLine());
        }
        Console.WriteLine("");

        //uso de FOREACH - percorre valores e realiza calculo 
        foreach (decimal somaNum in numeros)
        {
            soma += somaNum;
        }

        for (int y = 0; y < numeros.Length; y++)
        {
            Console.WriteLine("Valores primeiro Array " + y + ": " + numeros[y], "\t");
            multiplica[y] = numeros[y] * (soma / numeros.Length);
        }
        Console.WriteLine("");

        for (int z = 0; z < numeros.Length; z++)
        {
            Console.WriteLine("Valores segundo Array " + z + ": " + multiplica[z]);
        }

        //Console.WriteLine("Soma total: {0}", (soma));
        //Console.WriteLine("Média: {0}", (soma / numeros.Length));
    }
    static void Main(string[] args)
    {
        new Program();
    }
}

/*FOREACH - loops mais compactos, fáceis de ler e com uma sintaxe mais simplificada. • Em matrizes unidimensionais, a instrução foreach processa elementos em ordem crescente de índice, começando com o índice 0 e terminando com índice Length – 1. 
Exemplo listando os elementos de um array com foreach:

foreach (int elemento in array3)
    {
Console.WriteLine($"{elemento}");
    }*/