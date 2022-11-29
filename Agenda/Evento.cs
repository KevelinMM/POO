namespace Agenda;

public class Evento : Compromisso
{
    public char Tipo { get; set; } // aula, trabalho, social 
    public string Local { get; set; }
    public List<Participante> Participantes { get; set; }
    public char Status { get; set; }


    public Evento(string titulo, string descricao, DateTime dataHora, char tipo, string local, Participante participante, char status) : base(titulo, descricao, dataHora)
    {
        Tipo = tipo;
        Local = local;
        Participantes = new List<Participante>();
        if (participante != null)
        {
            Participantes.Add(participante);
        }
        Status = status;
    }

    public override string ToString()
    {
        return $"Tipo: {Tipo} \nLocal: {Local} " + CalculaPercentualConcluido();
    }

    public override string CalculaPercentualConcluido()
    {
        foreach (var item in Participantes)
        {
            Console.WriteLine(item);
        }

        return "\n";
    }
}
public class Participante
{
    public string Nome { get; set; }
    public string Telefone { get; set; }

    public Participante(string nome, string telefone)
    {
        Nome = nome;
        Telefone = telefone;
    }

    public override string ToString()
    {
        return $"Nome: {Nome} \nTelefone: {Telefone}";
    }
}