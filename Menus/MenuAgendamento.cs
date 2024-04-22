using Carrinho.BancoDeDados;
using Carrinho.Modelos.CadastroDeCarrinho;
using Carrinho.Modelos.Usuarios;
using Carrinho.SubMenus.Agendamentos;

namespace Carrinho.Menus;

internal class MenuAgendamento : Menu
{
    // Cria uma instância de CarrinhoContext
    public CarrinhoContext context;

    // Cria uma instância de DAL<CadastroContext> e passa o context para ela
    protected DAL<AgendamentoSemanal> agendamentoDAL;

    public MenuAgendamento()
    {
        // Todas vez que a class MenuAgendamento for chamada, ela vai iniciar as class's context e carrinhoDAL
        context = new CarrinhoContext();
        agendamentoDAL = new DAL<AgendamentoSemanal>(context);
    }

    public override void Executar(DAL<Usuario> usuarioDAL)
    {
        Console.Clear();
        ExibirTituloDaOpcao("Menu Agendamento");

        ExibirOpcoesDoMenu();
    }

    private void ExibirOpcoesDoMenu()
    {
        Console.Clear();
        ExibirTituloDaOpcao("Agendamento");

        Console.WriteLine("Digite 1 para realizar um agendamento");
        Console.WriteLine("Digite 2 para verificar agendamentos");
        Console.WriteLine("Digite 3 para voltar o menu principal");

        Console.Write("\nDigite sua opção: ");
        string opcaoEscolhida = Console.ReadLine()!;
        int opcaoEscolhidaNumerica;

        if (int.TryParse(opcaoEscolhida, out opcaoEscolhidaNumerica))
        {
            switch (opcaoEscolhidaNumerica)
            {
               case 1:
                    // Instanciando a classe e chamando o método correpondente
                    SubAddAgendamento agendamento1 = new SubAddAgendamento();
                    agendamento1.RegistrarAgendamento();
                    break;
            }
        }
    }
}