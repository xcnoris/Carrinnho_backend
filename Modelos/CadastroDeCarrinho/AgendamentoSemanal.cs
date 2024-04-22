namespace Carrinho.Modelos.CadastroDeCarrinho;
public class AgendamentoSemanal
{
    #region "Modelo Augusto"
    public AgendamentoSemanal(DateTime dataAgendamento, DateTime horarioAbertura, DateTime horarioFechamento)
    {

        DataAgendamento = dataAgendamento;
        HorarioAbertura = horarioAbertura;
        HorarioFechamento = horarioFechamento;
    }
    #endregion

    #region "Modelo Victor"
    //public AgendamentoSemanal(DateTime dataAbertura, DateTime dataEncerramento)
    //{
    //    DataAbertura = dataAbertura;
    //    DataEncerramento = dataEncerramento;
    //}
    #endregion
    /*  
        Ficaria assim a inclusao de um horario novo:
            HorarioSemanal horario = new HorarioSemanal(DiaDaSemana.Segunda, new TimeSpan(9, 0, 0), new TimeSpan(17, 0, 0));

        No exemplo que dei, new TimeSpan(9, 0, 0) representa 9 horas, 0 minutos e 0 segundos,
        ou seja, 9h da manhã, e new TimeSpan(17, 0, 0) representa 17 horas, 0 minutos e 0 segundos, ou seja, 5h da tarde 
    */
    #region "Modelo Augusto"

    #region "Modelo Augusto"
    //public DataAgendamento DataAgendamento { get; set; }
    #endregion

    public DateTime DataAgendamento { get; set; }
    public DateTime HorarioAbertura { get; set; }
    public DateTime HorarioFechamento { get; set; }
    #endregion
    public int Id { get; set; }

    #region "Modelo Augusto"
    //public DateTime DataAbertura { get; set; }
    //public DateTime DataEncerramento { get; set; }
    #endregion

    public ICollection<CadastroCarrinho> Carrinho { get; set; }

    public void AdicionarCarrinho(CadastroCarrinho carrinho)
    {
        Carrinho.Add(carrinho);
    }
}
#region "Modelo Augusto"
//public enum DataAgendamento
//{
//    Domingo,
//    Segunda,
//    Terca,
//    Quarta,
//    Quinta,
//    Sexta,
//    Sabado
//}
#endregion