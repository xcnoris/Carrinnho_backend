
namespace Carrinho.Modelos.CadastroDeCarrinho;

public class CadastroCarrinho
{
    public CadastroCarrinho()
    {
        // Este construtor vazio é necessário para o Entity Framework Core
    }

    public CadastroCarrinho(string name)
    {
        Nome = name;
        Disponivel = false;
    }

    public int Id { get; set; }
    public string Nome { get; set; }
    public bool Disponivel { get; set; }
    public ICollection<AgendamentoSemanal> AgendamentosDaSemana { get; set; }

    public void AdicionarAgendamento(AgendamentoSemanal agendamento)
    {
        AgendamentosDaSemana.Add(agendamento);
    }

    public void ExibirHorarios()
    {
        Console.WriteLine($"Lista de horarios da semana do {Nome}");
        foreach (var horario in AgendamentosDaSemana)
        {
            Console.WriteLine($"Dia da semana: {horario.DataAgendamento}");
            Console.WriteLine($"horario: de {horario.HorarioAbertura}h as {horario.HorarioFechamento}");
        }
    }

    public override string ToString()
    {
        return $@"Id: {Id}
            Nome: {Nome}
            Disponibilidade: {Disponivel}";
    }
}
