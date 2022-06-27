namespace FichaDeInscricao;

public class CobrarCurso
{
  private decimal ValorCurso;
  private decimal ValorMulta;
  private decimal ValorDesconto;

  public CobrarCurso(decimal valorCurso, decimal valorMulta, decimal valorDesconto)
  {
    this.ValorCurso = valorCurso;
    this.ValorMulta = valorMulta;
    this.ValorDesconto = valorDesconto;
  }
}