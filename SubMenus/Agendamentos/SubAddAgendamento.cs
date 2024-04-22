using Carrinho.Menus;
using Carrinho.Modelos.CadastroDeCarrinho;
using System.Globalization;

namespace Carrinho.SubMenus.Agendamentos
{
    internal class SubAddAgendamento : MenuAgendamento
    {
        internal void RegistrarAgendamento()
        {
            DateTime dataAgendamento;
            DateTime horaInicialAgendamento;
            DateTime horaEncerraAgendamento;

            Console.Clear();
            ExibirTituloDaOpcao("Cadastro de Agendamento");

            Console.WriteLine("Informe a data que deseja realizar o agendamento (Exemplo dd-mm-yyyy): ");
            string data = Console.ReadLine()!;
            dataAgendamento = DateTime.Parse(data);

            Console.WriteLine("Informe o horário que iniciará (Exemplo hh:mm): ");
            string horaInicial = Console.ReadLine()!;
            horaInicialAgendamento = DateTime.ParseExact(horaInicial, "HH:mm", CultureInfo.InvariantCulture);

            Console.WriteLine("Informe o horário de encerramento (Exemplo hh:mm): ");
            string horaEncerra = Console.ReadLine()!;
            horaEncerraAgendamento = DateTime.ParseExact(horaEncerra, "HH:mm", CultureInfo.InvariantCulture);

            Console.WriteLine($"Data Agendamento: {dataAgendamento.Date}");
            Console.WriteLine($"Hora Inicial do Agendamento: {horaInicialAgendamento}");
            Console.WriteLine($"Hora Encerramento do Agendamento: {horaEncerraAgendamento}");
                
            Console.Write("Digite qualquer coisa para continuar...");
            Console.ReadKey();

            // Cria objeto do agendamento
            AgendamentoSemanal agendamento = new AgendamentoSemanal(dataAgendamento, horaInicialAgendamento, horaEncerraAgendamento);
        }
    }
}
