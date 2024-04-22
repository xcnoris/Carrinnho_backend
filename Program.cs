using Carrinho.BancoDeDados;
using Carrinho.Modelos.Usuarios;
using Carrinho.Menus;


var context = new CarrinhoContext();
var usuariDAL = new DAL<Usuario>(context);

// Dicionarios de menus
Dictionary<int, Menu> opcoes = new();
opcoes.Add(1, new MenuRegistrarUsuario());
opcoes.Add(2, new MenuCarrinho());
opcoes.Add(3, new MenuAgendamento());
opcoes.Add(-1, new MenuSairDoPrograma());

void ExibirLogo()
{

    Console.WriteLine(@"

░█████╗░░█████╗░██████╗░██████╗░██╗███╗░░██╗██╗░░██╗░█████╗░
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██║████╗░██║██║░░██║██╔══██╗
██║░░╚═╝███████║██████╔╝██████╔╝██║██╔██╗██║███████║██║░░██║
██║░░██╗██╔══██║██╔══██╗██╔══██╗██║██║╚████║██╔══██║██║░░██║
╚█████╔╝██║░░██║██║░░██║██║░░██║██║██║░╚███║██║░░██║╚█████╔╝
░╚════╝░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚═╝╚═╝╚═╝░░╚══╝╚═╝░░╚═╝░╚════╝░");
    Console.WriteLine("\nBem vindo ao app do carrinho\n");
}

void ExibirOpcoesDoMenu()
{
    Console.Clear();
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar um usuario");
    Console.WriteLine("Digite 2 para acessar o menu de carrinho");
    Console.WriteLine("Digite 3 para agendar um horario");
    Console.WriteLine("Digite -1 para sair do app");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    if (opcoes.ContainsKey(opcaoEscolhidaNumerica))
    {
        Menu menuASerExibido = opcoes[opcaoEscolhidaNumerica];
        menuASerExibido.Executar(usuariDAL);
        if (opcaoEscolhidaNumerica > 0) ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine("Opção inválida");
    }
}
ExibirOpcoesDoMenu();