// Utilizando os conceitos iniciais de POO e a exemplificação que vimos, crie um sistema para cadastrar as
//disciplinas de um curso, devendo possuir seus respectivos alunos e notas. 

//dotnet run --project cadastroDisciplinas

namespace IntroducaoPOO;

internal class Program
{

    class Aluno
    {
        public string Nome { get; set; }
        public int Matricula { get; set; }
        public float Nota { get; set; }

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
        public void listarDisciplina(Disciplina disciplina)
        {
            Console.WriteLine($"Disciplina: {disciplina.NomeDisciplina} - Curso: {disciplina.NomeCurso}.");
            Console.WriteLine($"Alunos : ");

            foreach (var aluno in disciplina.AlunosCadastrados)
            {
                Console.WriteLine($" \r\n Nome do aluno: {aluno.Nome}, \r\n MAtricula do aluno: {aluno.Matricula}, \r\n Notas o aluno: {aluno.Nota}!");
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

        d1.listarDisciplina(d1);

        Console.WriteLine("Incluir alunos:");
    }
}

/*Kevelin Mondadori Mattos
        Aluno a1 = new Aluno();
        a1.Nome = "Nome do Aluno";
        a1.Matricula = 1234;
        a1.Nota = 10;
        Aluno a2 = new Aluno();
        a2.Nome = "Nome do Aluno";
        a2.Matricula = 1234;
        a2.Nota = 10;

        Console.WriteLine($"Disciplina: {d1.NomeDisciplina} - Curso: {d1.NomeCurso}.");
        Console.WriteLine($"Alunos : ");

        foreach (var aluno in d1.AlunosCadastrados)
        {
            Console.WriteLine($" \r\n Nome do aluno: {aluno.Nome}, \r\n MAtricula do aluno: {aluno.Matricula}, \r\n Notas o aluno: {aluno.Nota}!");
        }
*/
