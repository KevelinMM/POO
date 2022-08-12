class Program
{
    static void Main(string[] args)
    {

        decimal valor_total = 0, percentual_impostos = 0, valor_imposto = 0;

        Console.Write("Informe o valor da  nota fiscal:");
        string valor_nota = Console.ReadLine();

        decimal valor = decimal.Parse(valor_nota);
        if (valor <= 999)
        {
        percentual_impostos = 2;
        valor_imposto = valor * 0.02M;
        valor_total = (valor * 0.02M) + valor;
        }

        else if (valor >= 1000 && valor < 2999)
        {
            percentual_impostos = 2.5M;
            valor_imposto = valor * 0.025M;
            valor_total = (valor * 0.025M) + valor;
        }
        else if (valor >= 3000 && valor < 6999)
        {
            percentual_impostos = 2.8M;
            valor_imposto = valor * 0.028M;
            valor_total = (valor * 0.028M) + valor;
        }
        else
        {
            percentual_impostos = 3M;
            valor_imposto =  valor * 0.03M;
            valor_total = (valor * 0.03M) + valor;
        }

        Console.WriteLine($"Valor FINAL da nota fiscal: {valor_total}");
        Console.WriteLine($"Percentual aplicado  de imposto: {percentual_impostos} %");
        Console.WriteLine($"Valor do imposto: {valor_imposto}");
    }

}

