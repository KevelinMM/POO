/*Pra rodar: dotnet run --project Array2

Crie um programa que popule um array de 30 posições de inteiros
de forma randômica, e após mostre o seguinte:
• O conteúdo do array
• O menor valor armazenado e qual a sua posição
• O maior valor armazenado e qual a sua posição
• O valor médio do array

• Obs: caso os valores se repitam, mostre o primeiro.
*/

//Kevelin Mondadori Mattos
class Program
{
    Program()
    {
        decimal[] valores;
        decimal[] menor_valor;
        decimal[] maior_valor;
        int index = 0;
        decimal valor_medio;

        valores = new decimal[30];
        menor_valor = new decimal[2];
        maior_valor = new decimal[2];

        for (int i = 0; i < valores.Length; i++)
        {
            Console.Write("Digite o {0} valor: ", i);
            valores[i] = decimal.Parse(Console.ReadLine());
        }
        menor_valor[0] = valores[0];
        maior_valor[0] = valores[0];
        Console.WriteLine("");

        foreach (decimal numero in valores)
        {
            Console.WriteLine("Valores:{0} ", numero);
            if (numero < menor_valor[0])
            {
                menor_valor[0] = numero;
                menor_valor[1] = index;
            }
            if (numero > maior_valor[0])
            {
                maior_valor[0] = numero;
                maior_valor[1] = index;
            }
            index++;
        }

        valor_medio = valores.Sum() / valores.Length;
        Console.WriteLine("");
        Console.WriteLine("O menor valor eh {0} Na posição: {1}", menor_valor[0], menor_valor[1]);
        Console.WriteLine("O maior valor: {0} Na posição: {1}", maior_valor[0], maior_valor[1]);
        Console.WriteLine("Valor médio: {0}", valor_medio);
    }
    static void Main(string[] args) { new Program(); }
}





