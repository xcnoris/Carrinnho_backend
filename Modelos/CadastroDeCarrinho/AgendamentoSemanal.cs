using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrinho.Modelos.CadastroDeCarrinho;
public class AgendamentoSemanal
{
    #region "Modelo Augusto"
    public AgendamentoSemanal( DiaDaSemana diaDaSemana, TimeSpan horarioAbertura, TimeSpan horarioFechamento)
    {
        
        DiaDaSemana = diaDaSemana;
        HorarioAbertura = horarioAbertura;
        HorarioFechamento = horarioFechamento;
    }
    #endregion

    #region "Modelo Victor"
    public AgendamentoSemanal(DateTime dataAbertura, DateTime dataEncerramento)
    {
        DataAbertura = dataAbertura;
        DataEncerramento = dataEncerramento;
    }
    #endregion
    /*  
        Ficaria assim a inclusao de um horario novo:
            HorarioSemanal horario = new HorarioSemanal(DiaDaSemana.Segunda, new TimeSpan(9, 0, 0), new TimeSpan(17, 0, 0));

        No exemplo que dei, new TimeSpan(9, 0, 0) representa 9 horas, 0 minutos e 0 segundos,
        ou seja, 9h da manhã, e new TimeSpan(17, 0, 0) representa 17 horas, 0 minutos e 0 segundos, ou seja, 5h da tarde 
    */
    #region "Modelo Augusto"
    public int Id { get; set; }
    public DiaDaSemana DiaDaSemana { get; set; }
    public TimeSpan HorarioAbertura { get; set; }
    public TimeSpan HorarioFechamento { get; set; }
    #endregion

    #region "Modelo Victor"
    public DateTime DataAbertura { get; set; }
    public DateTime DataEncerramento { get; set; }
    #endregion

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