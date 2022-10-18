// Utilizando os conceitos iniciais de POO e a exemplificação que vimos, crie um sistema para cadastrar as
//disciplinas de um curso, devendo possuir seus respectivos alunos e notas. 

//dotnet run --project cadastroDisciplinas
//KEVELIN MONDADORI MATTOS

namespace IntroducaoPOO;
internal class Program
{
    class Aluno
    {
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public List<decimal> Nota = new List<decimal>();
        public void NotaAluno(decimal nota)
        {
            this.Nota.Add(nota);
        }

    }
    class Disciplina
    {
        public string NomeDisciplina { get; set; }
        public string NomeCurso { get; set; }
        public List<Aluno> AlunosCadastrados = new List<Aluno>();
        public void CadastrarAluno(Aluno aluno)
        {
            this.AlunosCadastrados.Add(aluno);
        }
        public void MediaDaTurma(Disciplina disciplina)
        {
            decimal mediaGeral = 0;
            int total = 0;
            foreach (var aluno in disciplina.AlunosCadastrados)
            {
                foreach (var notaAlunos in aluno.Nota)
                {
                    mediaGeral += notaAlunos;
                    total++;
                }
            }
            Console.WriteLine($"Média geral: {mediaGeral / total}");
        }
        public void listarDisciplina(Disciplina disciplina)
        {
            Console.WriteLine($"Disciplina: {disciplina.NomeDisciplina} - Curso: {disciplina.NomeCurso}.");
            Console.WriteLine($"Alunos: ");

            foreach (var aluno in disciplina.AlunosCadastrados)
            {
                Console.WriteLine($" \r\n Nome do aluno: {aluno.Nome}, \r\n Matricula do aluno: {aluno.Matricula},");
                decimal media = 0;
                decimal cont = 0;
                foreach (var nota in aluno.Nota)
                {
                    media += nota;
                    cont++;
                }
                Console.WriteLine($"Média do aluno: {media / cont}");

            }
        }
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("Cadastre uma disciplina:");
        Console.WriteLine("Nome da disciplina:");
        string disciplina = Console.ReadLine();
        Console.WriteLine("Nome do curso:");
        string curso = Console.ReadLine();

        Disciplina d1 = new Disciplina();
        d1.NomeDisciplina = disciplina;
        d1.NomeCurso = curso;
        string entradaTerminal = "";
        while (entradaTerminal != "0")
        {
            Console.WriteLine("Digite 1 para incluir alunos na disciplina com suas respectivas notas:");
            Console.WriteLine("Digite 2 para listar todos os alunos da disciplina mostrando sua média:");
            Console.WriteLine("Digite 3 para mostrar a média geral da turma:");
            Console.WriteLine("Digite 0 para finalizar o programa:");
            entradaTerminal = Console.ReadLine();
            int entrada = int.Parse(entradaTerminal);
            switch (entrada)
            {
                case 1:
                    Console.WriteLine("Nome do aluno:");
                    string nomeAluno = Console.ReadLine();
                    Console.WriteLine("Matricula do aluno:");
                    string matriculaAluno = Console.ReadLine();
                    Aluno a1 = new Aluno();
                    a1.Nome = nomeAluno;
                    a1.Matricula = matriculaAluno;
                    Console.WriteLine("Digite FIM para encerrar as notas:");
                    string recebeNotas = "";
                    int contador = 1;
                    while (recebeNotas != "FIM")
                    {
                        Console.WriteLine("{0} Nota do aluno:", contador);
                        recebeNotas = Console.ReadLine();
                        if (recebeNotas != "FIM")
                        {
                            decimal nota = decimal.Parse(recebeNotas);
                            a1.NotaAluno(nota);
                            contador++;
                        }
                    }
                    d1.CadastrarAluno(a1);
                    break;
                case 2:
                    d1.listarDisciplina(d1);
                    break;
                case 3:
                    d1.MediaDaTurma(d1);
                    break;
            }
        }
    }
}

