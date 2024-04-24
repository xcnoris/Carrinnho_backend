using Carrinho.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrinho.SubMenus.SubUsuario
{
    internal class SubListarUsuarios : MenuUsuario
    {
        public void ListarUsuarios()
        {
            ExibirTituloDaOpcao("Lista de Usuarios");

            Console.WriteLine("Usuarios cadastrados no app: \n");
            try
            {
                
                foreach (var usuario in usuarioDAL.Listar())
                {
                    Console.WriteLine("=====================================");
                    Console.WriteLine($"ID: {usuario.Id}");
                    Console.WriteLine($"Nome: {usuario.Nome}");
                    Console.WriteLine($"CPF: {usuario.CPF.Substring(0, 3)}.{usuario.CPF.Substring(3, 3)}.{usuario.CPF.Substring(6, 3)}-{usuario.CPF.Substring(9)}");
                    Console.WriteLine($"Data nascimento: {usuario.DataNascimento.ToString("dd/MM/yyyy")}");
                    Console.WriteLine($"Email: {usuario.Email}");
                    Console.WriteLine($"Tipo: {usuario.Tipo}");
                    Console.WriteLine($"Criado em: {usuario.DataCriacao}\n");
                   
                }
                Console.WriteLine("=====================================");
                Console.Write("\nDigite qualquer coisa para continuar...");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um [ERRO]: {ex.Message}");
                Console.Write("\nDigite qualquer coisa para continuar...");
                Console.ReadKey();
            }
        }
    }
}
