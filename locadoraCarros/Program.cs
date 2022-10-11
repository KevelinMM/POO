
namespace IntroducaoPOO;

internal class Program
{
    class Carro
    {
        public string Marca;
        public string Placa;
        public int Ano;
        public string Estado;
        public string Cor;
    }
    class Revenda
    {
        public string Nome;
        public int AnoRevenda;
        public List<Carro> CarrosRevenda = new List<Carro>();

        public void AdiconarCarros(Carro carro)
        {
            this.CarrosRevenda.Add(carro);
        }
    }
    private static void Main(string[] args)
    {

        Carro c1 = new Carro();
        c1.Marca = "Peugeot";
        c1.Placa = "ACDP";
        c1.Ano = 2010;
        c1.Estado = "Usado";
        c1.Cor = "Prata";
        Carro c2 = new Carro();
        c2.Marca = "Honda";
        c2.Placa = "RYB";
        c2.Ano = 2022;
        c2.Estado = "Novo";
        c2.Cor = "Preto";

        Revenda revenda01 = new Revenda();
        revenda01.Nome = "Kevelin Mondadori";
        revenda01.AnoRevenda = 2020;
        revenda01.AdiconarCarros(c1);
        revenda01.AdiconarCarros(c2);

        Console.WriteLine($"Cliente: {revenda01.Nome} - Data da revenda: {revenda01.AnoRevenda}.");
        Console.WriteLine($"Carros : ");
        foreach (var carro in revenda01.CarrosRevenda)
        {
            Console.WriteLine($" \r\n Placa: {carro.Placa}, \r\n Marca: {carro.Marca}, \r\n Estado: {carro.Estado}, \r\n Ano: {carro.Ano}, \r\n Cor: {carro.Cor}");
        }
    }
}

//Kevelin Mondadori Mattos
