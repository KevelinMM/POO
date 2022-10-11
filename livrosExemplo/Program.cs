
namespace IntroducaoPOO;

internal class Program
{
    class Livro
    {
        public string Titulo;
        public string SubTitulo;
        public string Escritor;
    }
    class Leitor
    {
        public string Nome;
        public byte Idade;
        public List<Livro> LivrosLeitor = new List<Livro>();

        public void AdiconarLivro(Livro livro)
        {
            this.LivrosLeitor.Add(livro);
        }
    }
    private static void Main(string[] args)
    {

        Livro l1 = new Livro();
        l1.Titulo = "O contador de Histórias";
        l1.SubTitulo = "Memórias de vida e música";
        l1.Escritor = "Dave Grohl";
        Livro l2 = new Livro();
        l2.Titulo = "O guia do Mochileiro das Galáxias";
        l2.SubTitulo = "Não entre em pânico";
        l2.Escritor = "Douglas Adams";
        Livro l3 = new Livro();
        l3.Titulo = "Memórias de um legionário";
        l3.Escritor = "Dado Villa-Lobos";

        Leitor leitor01 = new Leitor();
        leitor01.Nome = "Luciano Coelho";
        leitor01.Idade = 46;
        leitor01.AdiconarLivro(l1);
        leitor01.AdiconarLivro(l2);
        leitor01.AdiconarLivro(l3);

        Console.WriteLine($"{leitor01.Nome}, {leitor01.Idade} anos.");
        Console.WriteLine($"Livros: ");
        foreach (var livro in leitor01.LivrosLeitor)
        {

            Console.WriteLine($"{livro.Titulo}, {livro.Escritor}");

        }
    }


}
