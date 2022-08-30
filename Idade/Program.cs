class Program
{
    static void Main(string[] args)
    {
        Console.Write("Informe sua idade:");
        String idade = Console.ReadLine();

        byte resposta = byte.Parse(idade);
        if (resposta <= 12)
        {
            Console.WriteLine("Uma criança!");
        }
        else if (resposta > 12 && resposta < 18)
        {
            Console.WriteLine("Um adolescente!");
        }
        else
        {
            Console.WriteLine("Um adulto!!");
        }
    }
}
