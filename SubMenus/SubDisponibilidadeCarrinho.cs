using Carrinho.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrinho.SubMenus
{
    internal class SubDisponibilidadeCarrinho : MenuCarrinho
    {

        // Muda a disponibilidade do carrinho
        public void DisponibilidadeCarrinho()
        {
            Console.Clear();
            ExibirTituloDaOpcao("Disponibilidade do carrinho");


            // Lista todos os carrinhos cadastrados
            Console.WriteLine("Lista de carrinhos cadastrados:\n");
            foreach (var carrinho in carrinhoDAL.Listar())
            {
                Console.WriteLine($"Carrinho: {carrinho}");
            }

            // usuario informar qual o carinho que vai alterar a disponibilidade 
            Console.WriteLine("\nDigite o id do carrinho que gostaria de mudar a disponibilidade:");
            if (int.TryParse(Console.ReadLine(), out int idCarrinho))
            {
                var carrinhoAAtualizar = carrinhoDAL.RecuperarPor(a => a.Id == idCarrinho);
                if (carrinhoAAtualizar != null)
                {
                    try
                    {
                        // Inverte a disponibilidade do carrinho selecionado
                        carrinhoAAtualizar.Disponivel = !carrinhoAAtualizar.Disponivel;
                        // Atualiza no banco
                        carrinhoDAL.Atualizar(carrinhoAAtualizar);

                        Console.WriteLine($"O carrinho {carrinhoAAtualizar.Nome} foi atualizado!");
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
                else
                {
                    Console.WriteLine($"Não foi encontrado nenhum carrinho cadastrado com o ID {idCarrinho}");
                    Console.Write("\nDigite qualquer coisa para continuar...");
                    Console.ReadKey();
                }

            }
            else
            {
                Console.WriteLine("ID inválido. Por favor, insira um número inteiro válido.");
                Console.Write("\nDigite qualquer coisa para continuar...");
                Console.ReadKey();
            }

        }

    }
}
