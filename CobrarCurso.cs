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
    this.ValorCurso = valorCurso;
    this.ValorMulta = valorMulta;
    this.ValorDesconto = valorDesconto;
    this.Resultado = this.Calcular(valorCurso, valorMulta, valorDesconto);
  }
  //MÉTODO
  private decimal Calcular(decimal valorCurso, decimal valorMulta, decimal valorDesconto)
  {
    if (this.ValorMulta > 0)
    {
      return this.ValorCurso + this.ValorMulta;
    }
    else
    {
      return this.ValorCurso - this.ValorDesconto;
    }

  }

}