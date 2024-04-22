using Carrinho.BancoDeDados;
using Carrinho.Modelos.CadastroDeCarrinho;
using Carrinho.Modelos.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrinho.Menus;

internal class Menu
{
    public void ExibirTituloDaOpcao(string titulo)
    {
        int quantidadeDeLetras = titulo.Length;
        string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
        Console.WriteLine(asteriscos);
        Console.WriteLine(titulo);
        Console.WriteLine(asteriscos + "\n");
    }
    public virtual void Executar(DAL<Usuario> horarioDAL)
    {
        Console.Clear();
    }

    public void ExibirLogoSair()
    {

        Console.WriteLine(@"

░█████╗░░█████╗░██████╗░██████╗░██╗███╗░░██╗██╗░░██╗░█████╗░
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██║████╗░██║██║░░██║██╔══██╗
██║░░╚═╝███████║██████╔╝██████╔╝██║██╔██╗██║███████║██║░░██║
██║░░██╗██╔══██║██╔══██╗██╔══██╗██║██║╚████║██╔══██║██║░░██║
╚█████╔╝██║░░██║██║░░██║██║░░██║██║██║░╚███║██║░░██║╚█████╔╝
░╚════╝░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚═╝╚═╝╚═╝░░╚══╝╚═╝░░╚═╝░╚════╝░");
    }
}
