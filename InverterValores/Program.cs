class Program
{
    static void Main(string[] args)
    {
        Console.Write("Informe numero A: ");
        string ta = Console.ReadLine();
        Console.Write("Informe numero B: ");
        string tb = Console.ReadLine();

        int a = int.Parse(ta);
        int b = int.Parse(tb);

        a += b;
        b = a - b;
        a -= b;

        Console.WriteLine($"A: {a}");
        Console.WriteLine($"A: {b}");
    }
}
