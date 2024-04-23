using Carrinho.BancoDeDados;
using Carrinho.Modelos.CadastroDeCarrinho;
using Carrinho.Modelos.Usuarios;
using Carrinho.SubMenus.SubCarrinho;
using Carrinho.SubMenus.SubUsuario;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrinho.Menus;
internal class MenuUsuario : Menu
{
    // Crie uma instância de CarrinhoContext
    public CarrinhoContext context;
    // Cria uma instância de DAL<CadastroCarrinho> e passa o context para ela
    protected DAL<Usuario> usuarioDAL;
    public MenuUsuario()
    {
        // Toda vez que a class MenuCarrinho for chamada, ela vai iniciarão as class context e carrinhoDAL
        context = new CarrinhoContext();
        usuarioDAL = new DAL<Usuario>(context);
    }

    // Metodo Executar da class 
    public override void Executar(DAL<Usuario> usuarioDAL)
    {
        Console.Clear();
        ExibirTituloDaOpcao("Menu Usuario");
        ExibirOpcoesDoMenu();
    }


    private void ExibirOpcoesDoMenu()
    {
        Console.WriteLine("Digite 1 para cadastrar um usuario");
        Console.WriteLine("Digite 2 para bloquear/liberar um usuario");
        Console.WriteLine("Digite 3 para voltar ao menu anterior");

        Console.Write("\nDigite a sua opção: ");
        string opcaoEscolhida = Console.ReadLine()!;
        int opcaoEscolhidaNumerica;

        if (int.TryParse(opcaoEscolhida, out opcaoEscolhidaNumerica))
        {
            switch (opcaoEscolhidaNumerica)
            {
                case 1:
                    // Instanciando class e chamando seu respectivo metodo
                    SubCadastroUsuario usuario1 = new SubCadastroUsuario();
                    usuario1.CadastrarUsuario();
                    break;
                case 2:
                    //Desenvolver
                    break;
                case 3:
                    break;

                default:
                    Console.WriteLine("Opção inválida");
                    Console.Write("\nDigite qualquer coisa para continuar...");
                    Console.ReadKey();
                    break;
            }
        }
        else
        {
            Console.WriteLine("Opção inválida");
            Console.Write("\nDigite qualquer coisa para continuar...");
            Console.ReadKey();
        }

    }

}