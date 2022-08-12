class Program
{
    static void Main(string[] args)
    {
        Random randNum = new Random();

        int valorR = randNum.Next(0, 10);
        Console.Write("Informe um valor inteiro entre 0 e 10:");
        String valor = Console.ReadLine();


        int resposta = int.Parse(valor);
        if (resposta == valorR)
        {
            Console.WriteLine("Parabéns! Você acertou o número!");
        }
        else if (resposta > valorR)
        {
            Console.WriteLine("Deveria ser um numero menor!");
        }
        else if (resposta < valorR)
        {
            Console.WriteLine("Deveria ser um numero maior!");
        }
        else
        {
            Console.WriteLine("Errou!!!!!");
        }
                    Console.WriteLine(valorR);
    }
}