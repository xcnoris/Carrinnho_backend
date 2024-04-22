using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrinho.Modelos.Usuarios;

internal class Usuario
{
    public Usuario()
    {
        // Este construtor vazio é necessário para o Entity Framework Core
    }

    public Usuario(string nome, string cPF, DateTime dataNascimento, string gmail, string senha, TipoUsuario tipo)
    {
        Nome = nome;
        CPF = cPF;
        DataNascimento = dataNascimento;
        Email = gmail;
        Senha = senha;
        DataCriacao = DateTime.Now;
        Tipo = tipo;

    }
    public int Id { get; set; }
    public string Nome { get; set; }
    public string CPF { get; set; }
    public DateTime DataNascimento { get; set; }
    public string Email { get; set; }
    public string Senha { get; set; }
    public DateTime DataCriacao { get; set; }
    public TipoUsuario Tipo { get; set; }


    public override string ToString()
    {
        return $@"Nome: {Nome}
            Cpf: {CPF}
            Gmail: {Email}
            Data de Nascimento: {DataNascimento}";
    }

}

public enum TipoUsuario
{
    ADM =1,
    Gerente =2,
    Comum =3
}