using Carrinho.Modelos.CadastroDeCarrinho;
using Carrinho.Modelos.Usuarios;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Carrinho.BancoDeDados;

internal class CarrinhoContext : DbContext
{
    // Incluir a string de conexao com o banco aqui
    //Servidor private string connetionString = "Data Source=26.145.70.47;Initial Catalog=CarrinhoBD;User ID=sa;Password=********;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
    private string connetionString = "Data Source=XCNORIS;Initial Catalog=carrinhoBD;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
    
    // Metodo de conexao com o banco usando o context
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(connetionString);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CadastroCarrinho>()
          .HasMany(c => c.AgendamentosDaSemana)
          .WithMany(a => a.Carrinho)
          .UsingEntity(j => j.ToTable("CadastroCarrinhoAgendamento"));
    }

    /*
        Os objetos DbSet são usados para trabalhar com os conjuntos
        de entidades, nesse caso, entidades do tipo Receita.
    */
    // Referenciando das class 
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<CadastroCarrinho> CarrinhoCadastrados { get; set; }
    public DbSet<AgendamentoSemanal> HorarioDaSemana { get; set; }

}
