using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrinho.Menus;

internal class MenuAgendamento : Menu
{
    public void Executar()
    {
        Console.Clear();
        ExibirTituloDaOpcao("Menu Agendamento");
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
            {
               // case 1:
            }
        }
    }
}
