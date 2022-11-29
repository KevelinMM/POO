namespace Agenda;

public class Tarefa : Compromisso
{
    public char Prioridade { get; set; }
    public List<ItensTarefa> Itens { get; set; }

    public Tarefa(string titulo, string descricao, DateTime dataHora, char prioridade, ItensTarefa item) : base(titulo, descricao, dataHora)
    {
        Prioridade = prioridade;
        Itens = new List<ItensTarefa>();
        if (item != null)
        {
            Itens.Add(item);
        }
    }

    public override string ToString()
    {
       return $"Prioridade: {Prioridade}";
    }
    
    public override void CalculaPercentualConcluido()
    {
        foreach(var item in Itens){
            Console.WriteLine(item);
        } 
    }


}

public class ItensTarefa
{
    public string Titulo { get; set; }
    public bool Status { get; set; }

    public ItensTarefa(string titulo, bool status)
    {
        Titulo = titulo;
        Status = status;
    }

    public override string ToString()
    {
       return $"Titulo: {Titulo} \nStatus: {Status}";
    }
    
}