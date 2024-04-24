using Carrinho.BancoDeDados;
using Carrinho.Modelos.Usuarios;

namespace Carrinho.Menus;

internal class Menu
{
    public void ExibirTituloDaOpcao(string titulo)
    {
        Console.Clear();
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
