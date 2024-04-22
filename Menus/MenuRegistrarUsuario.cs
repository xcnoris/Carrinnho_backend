using Carrinho.BancoDeDados;
using Carrinho.Modelos.CadastroDeCarrinho;
using Carrinho.Modelos.Usuarios;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrinho.Menus;
internal class MenuRegistrarUsuario : Menu
{
    public override void Executar(DAL<Usuario> usuarioDAL)
    {
        try
        {
            Console.Clear();
            ExibirTituloDaOpcao("Cadastro de Usuario");

            Console.WriteLine("Qual o nome do usuário?");
            var nome = Console.ReadLine();

            Console.WriteLine("Qual o CPF do usuário? (apenas números)");
            var cpf = Console.ReadLine();

            if (!ValidarCPF(cpf))
            {
                Console.WriteLine("CPF inválido. Por favor, insira um CPF válido.");
                Thread.Sleep(4000);
                return;
            }

            Console.WriteLine("Qual a data de nascimento do usuário? (no formato DD/MM/AAAA)");
            var dataNascimentoString = Console.ReadLine();
            if (!DateTime.TryParseExact(dataNascimentoString, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataNascimento))
            {
                Console.WriteLine("Data de nascimento inválida. Por favor, insira uma data válida no formato DD/MM/AAAA.");
                Thread.Sleep(4000);
                return;
            }

            Console.WriteLine("Qual o email do usuário?");
            var email = Console.ReadLine();
            if (!ValidarEmail(email))
            {
                Console.WriteLine("Email inválido. Por favor, insira um email válido.");
                Thread.Sleep(4000);
                return;
            }

            Console.WriteLine("Qual a senha que o usuário vai usar?");
            var senha = Console.ReadLine();

            Console.WriteLine("Qual o tipo do novo usuário? (1 para Administrador, 2 para Gerente, 3 para usuario comum)");
            var tipo = Console.ReadLine();
            if (!Enum.TryParse<TipoUsuario>(tipo, out TipoUsuario tipoUsuario) || !Enum.IsDefined(typeof(TipoUsuario), tipoUsuario))
            {
                Console.WriteLine("Tipo de usuário inválido. Por favor, insira 1 para Administrador ou 2 para Cliente.");
                Thread.Sleep(4000);
                return;
            }

            var novoUsuario = new Usuario(nome, cpf, dataNascimento, email, senha, tipoUsuario);
            usuarioDAL.Adicionar(novoUsuario);
            Console.WriteLine($"O usuário {nome} foi registrado com sucesso!");
            Thread.Sleep(4000);
        }
        catch (Exception excecao)
        {
            Console.WriteLine($"Ocorreu um [ERRO]: {excecao.Message}");
            Thread.Sleep(4000);
        }
    }

    private bool ValidarCPF(string cpf)
    {
        return true;
        // Adicione sua lógica de validação de CPF aqui
        // Retorne true se o CPF for válido e false caso contrário
    }

    private bool ValidarEmail(string email)
    {
        return true;
        // Adicione sua lógica de validação de email aqui
        // Retorne true se o email for válido e false caso contrário
    }
}
