using Carrinho.BancoDeDados;
using Carrinho.Modelos.CadastroDeCarrinho;
using Carrinho.Modelos.Usuarios;
using Carrinho.SubMenus;

namespace Carrinho.Menus
{
    internal class MenuCarrinho : Menu
    {
        // Crie uma instância de CarrinhoContext
        public CarrinhoContext context;

        // Cria uma instância de DAL<CadastroCarrinho> e passa o context para ela
        protected DAL<CadastroCarrinho> carrinhoDAL;
        public MenuCarrinho()
        {
            // Toda vez que a class MenuCarrinho for chamada, ela vai iniciarão as class context e carrinhoDAL
            context = new CarrinhoContext();
            carrinhoDAL = new DAL<CadastroCarrinho>(context);
        }

        // Metodo Executar da class 
        public override void Executar(DAL<Usuario> usuarioDAL)
        {
            Console.Clear();
            ExibirTituloDaOpcao("Menu Carrinho");

            ExibirOpcoesDoMenu();
        }

        private void ExibirOpcoesDoMenu()
        {
            Console.Clear();
            ExibirTituloDaOpcao("Carrinho\n");

            Console.WriteLine("Digite 1 para registrar um carrinho");
            Console.WriteLine("Digite 2 para bloquear/liberar um carrinho");
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
                        SubCadastroCarrinho carrinho1 = new SubCadastroCarrinho();
                        carrinho1.RegistrarCarrinho();
                        break;
                    case 2:
                        SubDisponibilidadeCarrinho carrinho2 = new SubDisponibilidadeCarrinho();
                        carrinho2.DisponibilidadeCarrinho();
                        break;
                    case 3:
                        break;
               
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Opção inválida");
                Thread.Sleep(4000);
            }
        }
    }
}
