namespace FichaDeInscricao;

public class CobrarCurso
{
  private decimal ValorCurso;
  private decimal ValorMulta;
  private decimal ValorDesconto;

  private decimal Resultado;

  //CONSTRUTOR
  public CobrarCurso(decimal valorCurso, decimal valorMulta, decimal valorDesconto)
  {
    ValorCurso = valorCurso;
    ValorMulta = valorMulta;
    ValorDesconto = valorDesconto;
    Resultado = this.Calcular(valorCurso, valorMulta, valorDesconto);
  }
  //MÉTODO
  private decimal Calcular(decimal valorCurso, decimal valorMulta, decimal valorDesconto)
  {
    if (ValorMulta > 0)
    {
      return ValorCurso + ValorMulta;
    }
    else
    {
      return ValorCurso - ValorDesconto;
    }

  }

}