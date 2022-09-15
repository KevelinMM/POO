//Pra rodar: dotnet run --project Array1
//Kevelin Mondadori Mattos

class Program
{
    Program()
    {
        //Variaveis
        int n;
        decimal soma = default;
        decimal[] numeros;

        // cria o array com a quantidade de posições indicada
        numeros = new decimal[10];

        //Leitura e armazenameno
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write("Digite o {0} valor: ", i);
            numeros[i] = decimal.Parse(Console.ReadLine());

        }

        //uso de FOREACH - percorre valores e realiza calculo 
        foreach (decimal somaNum in numeros)
        {
            soma += somaNum;
        }
        Console.WriteLine("Média: {0}", (soma / numeros.Length));
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