using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrinho.BancoDeDados;

// Class DAL que representa todos os metodos das class com relacionamento com tabelas no banco
// Usamos o where para dizer que o T vai representar uma class
internal class DAL<T> where T : class
{
    protected readonly CarrinhoContext context;

    public DAL(CarrinhoContext context)
    {

        this.context = context;
    }

    // Metodo listar musicas
    public IEnumerable<T> Listar()
    {
        // Usamos o generic Set para pegar o tpo da class  que estamos ultiliazando ao chamar o metodo
        return context.Set<T>().ToList();
    }

    // Metodo Adicionar musicas
    public void Adicionar(T objeto)
    {
        context.Set<T>().Add(objeto);
        context.SaveChanges();
    }

    //Metodo atualizar musicas
    public void Atualizar(T objeto)
    {
        context.Set<T>().Update(objeto);
        context.SaveChanges();
    }

    // Metodo Deletar musica
    public void Deletar(T objeto)
    {
        context.Set<T>().Remove(objeto);
        context.SaveChanges();
    }

    //Metodo RecuperarPor
    // Usamos o Func quando precisamos representar um método sem ter que passar especificamente valores personalizados
    // O metodo RecuperarPor pode filtrar por Nome, Id, etc...

    public T? RecuperarPor(Func<T, bool> condicao)
    {
        return context.Set<T>().FirstOrDefault(condicao);
    }






}
