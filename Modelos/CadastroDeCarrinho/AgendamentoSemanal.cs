using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrinho.Modelos.CadastroDeCarrinho;
public class AgendamentoSemanal
{
    public AgendamentoSemanal( DiaDaSemana diaDaSemana, TimeSpan horarioAbertura, TimeSpan horarioFechamento)
    {
        
        DiaDaSemana = diaDaSemana;
        HorarioAbertura = horarioAbertura;
        HorarioFechamento = horarioFechamento;
    }
    /*  
        Ficaria assim a inclusao de um horario novo:
            HorarioSemanal horario = new HorarioSemanal(DiaDaSemana.Segunda, new TimeSpan(9, 0, 0), new TimeSpan(17, 0, 0));

        No exemplo que dei, new TimeSpan(9, 0, 0) representa 9 horas, 0 minutos e 0 segundos,
        ou seja, 9h da manhã, e new TimeSpan(17, 0, 0) representa 17 horas, 0 minutos e 0 segundos, ou seja, 5h da tarde 
    */
    public int Id { get; set; }
    public DiaDaSemana DiaDaSemana { get; set; }
    public TimeSpan HorarioAbertura { get; set; }
    public TimeSpan HorarioFechamento { get; set; }
    public ICollection<CadastroCarrinho> Carrinho { get; set; }


    public void AdicionarCarrinho(CadastroCarrinho carrinho)
    {
        Carrinho.Add(carrinho);
    }

}
public enum DiaDaSemana
{
    Domingo,
    Segunda,
    Terca,
    Quarta,
    Quinta,
    Sexta,
    Sabado
}



