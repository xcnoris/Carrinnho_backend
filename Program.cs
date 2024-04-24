﻿using Carrinho.BancoDeDados;
using Carrinho.Modelos.Usuarios;
using Carrinho.Menus;

//UsuarioComum usuarioComum1 = new UsuarioComum("Augusto Nascimento", "058.027.862-05", "07/01/2006", "augustobriel12@gmail.com", "123c456");
//Console.WriteLine(usuarioComum1.ToString());


var context = new CarrinhoContext();
var usuariDAL = new DAL<Usuario>(context);

// Dicionarios de menus
Dictionary<int, Menu> opcoes = new();
opcoes.Add(1, new MenuUsuario());
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
    Console.WriteLine("\nDigite 1 para acessa o menu de usuarios");
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