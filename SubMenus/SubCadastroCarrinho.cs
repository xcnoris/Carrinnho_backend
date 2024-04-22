using Carrinho.Menus;
using Carrinho.Modelos.CadastroDeCarrinho;

namespace Carrinho.SubMenus
{
    internal class SubCadastroCarrinho : MenuCarrinho
    {
        // registra um novo carrinho
        public void RegistrarCarrinho()
        {
            Console.Clear();
            ExibirTituloDaOpcao("Cadastro de Carrinho");

            Console.WriteLine("Qual o nome do novo carrinho?");
            string nome = Console.ReadLine()!;
            // Cria o objeto do carrinho
            CadastroCarrinho carrinho = new CadastroCarrinho(nome);

            try
            {
                // Chama a instancia do DAL, adiciona no banco o carrinho
                carrinhoDAL.Adicionar(carrinho);
                Console.WriteLine();
                Console.WriteLine($"O carrinho {nome} foi registrado com sucesso!");
                Thread.Sleep(4000);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um [ERRO]: {ex.Message}");
            }

        }
    }
}
