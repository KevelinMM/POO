namespace Agenda;
internal class Program
{
    private static void Main(string[] args)
    {
        Tarefa t1 = new Tarefa("T1","Tarefa 01", new DateTime(2022,11,22, 21,33,00), 'A', new ItensTarefa("Comprar leite",false) );
        Evento e1 = new Evento("E1","Evento 01", new DateTime(2022,11,22, 21,33,00), 'N', "Casa", new Participante("Luciano","49123"),'A');

        Compromisso c1 = new Tarefa("T1","Tarefa 01", new DateTime(2022,11,22, 21,33,00), 'A', new ItensTarefa("Comprar leite",false) );
        Compromisso c2 = new Evento("E1","Evento 01", new DateTime(2022,11,22, 21,33,00), 'N', "Casa", new Participante("Luciano","49123"),'A');


        List<Compromisso> Agenda = new List<Compromisso>();
        Agenda.Add(t1);
        Agenda.Add(e1);
        Agenda.Add(c1);
        Agenda.Add(c2);

        foreach (var item in Agenda)
        {
            Console.WriteLine(item);
            Console.WriteLine(item.CalculaPercentualConcluido());
        }
    }
}