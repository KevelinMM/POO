namespace Agenda;

public abstract class Compromisso
{
    public string Titulo { get; set; }
    public string Descricao { get; set; }
    public DateTime DataHora { get; set; }

    public Compromisso(string titulo, string descricao, DateTime dataHora)
    {
        Titulo = titulo;
        Descricao = descricao;
        DataHora = dataHora;
    }

    public abstract string CalculaPercentualConcluido();
}