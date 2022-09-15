internal class Program
{
    public Program()
    {
        // invocando a execução do método
        Calcula();
        // invoca o método e armazena o seu retorno em uma variável
        int retorno = CalculaComRetorno();
        Console.WriteLine("Resultado com retorno: {0}", retorno);
        // invoca o método passando o valor dos argumentos
        int aux1 = 10, aux2 = 60;
        int retorno2 = CalculaComParametros(aux1, aux2);
        Console.WriteLine("Resultado com parâmetros: {0}", retorno2);
    }
    public void Calcula()
    {
        int x = 10, y = 90;
        int r = x + y;
        Console.WriteLine($"Resultado: {r}");
    }
    public int CalculaComRetorno()
    {
        int x = 10, y = 90;
        int r = x + y;
        return r;
    }
    public int CalculaComParametros(int x, int y)
    {
        int r = x + y;
        return r;
    }
    private static void Main(string[] args)
    {
        var prog = new Program();
    }
}