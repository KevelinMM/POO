// Kevelin Mondadori Mattos
internal class Program
{
    public Program()
    {
        Console.Write("Informe o primeiro valor: ");
        int Primeiro = int.Parse(Console.ReadLine());
        Console.Write("Informe o segundo valor: ");
        int Segundo = int.Parse(Console.ReadLine());
        Console.Write("Informe o terceiro valor: ");
        int Terceiro = int.Parse(Console.ReadLine());
        Console.Write("Informe o quarto valor: ");
        int Quarto = int.Parse(Console.ReadLine());
        (int soma, decimal media) retorno = Calcula(Primeiro, Segundo, Terceiro, Quarto);
        Console.WriteLine($"Soma das notas: {retorno.soma} Media das notas: {retorno.media}");
    }
    public (int, decimal) Calcula(int primeiro, int segundo, int terceiro, int quarto)
    {
        int Soma = primeiro + segundo + terceiro + quarto;
        decimal Media = Soma / 4m;
        return (Soma, Media);
    }
    static void Main(string[] args)
    {
        new Program();
    }
}



