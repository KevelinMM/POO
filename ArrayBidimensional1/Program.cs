//Crie um programa que popule automaticamente com valores inteiros
//um array bidimensional nas dimensões 4 x 5 e mostre o seguinte:
//• A soma de todos os valores
//• A média dos valores

//dotnet new console -o ProgramName

internal class Program
{
    static void Main(string[] args)
    {
        new Program();
        decimal[,] array2D = new decimal[4, 5];
        array2D[2, 3] = 2;
        //int soma = 0;
        //decimal[] media;

        for (int linha = 0; linha < array2D.GetLength(0); ++linha)
        {
            for (int coluna = 0; coluna < array2D.GetLength(1); ++coluna)
            {
                Console.Write("{0}, ", array2D[linha, coluna]);
            }
            Console.WriteLine();
            //soma++;
        }
    }
}
