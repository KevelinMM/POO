class Program
{
    static void Main(string[] args)
    {
        decimal novo_salario, ajuste;

        Console.Write("Informe o salario do funcionario:");
        string salar = Console.ReadLine();
        Console.Write("Informe o código do cargo desse funcionario:");
        string valor = Console.ReadLine();

        int codigo = int.Parse(valor);
        decimal salario = decimal.Parse(salar);

        switch (codigo)
        {
            case 1:
                novo_salario = (salario * 0.1M) + salario;
                ajuste = salario * 0.1M;
                break;

            case 2:
                novo_salario = (salario * 0.2M) + salario;
                ajuste = salario * 0.2M;
                break;

            case 3:
                novo_salario = (salario * 0.3M) + salario;
                ajuste = salario * 0.3M;
                break;

            case 4:
                novo_salario = (salario * 0.1M) + salario;
                ajuste = salario * 0.1M;
                break;

            default:
                novo_salario = (salario * 0.4M) + salario;
                ajuste = salario * 0.4M;
                break;
        }

        Console.WriteLine($"O novo salario eh de: {novo_salario}");
        Console.WriteLine($"O antigo salario era de: {salario} ");
        Console.WriteLine($"A diferença foi de: {ajuste}");

    }
}
