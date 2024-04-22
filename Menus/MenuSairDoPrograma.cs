using Carrinho.BancoDeDados;
using Carrinho.Modelos.CadastroDeCarrinho;
using Carrinho.Modelos.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrinho.Menus;

internal class MenuSairDoPrograma : Menu
{
    public override void Executar(DAL<Usuario> usuarioDAL)
    {
        Console.Clear();
        Console.WriteLine("Tchau Tchau :)");
    }
}
