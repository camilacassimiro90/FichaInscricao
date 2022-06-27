namespace FichaDeInscricao;

public class CobrarCurso
{
  private decimal ValorCurso;
  private decimal ValorMulta;
  private decimal ValorDesconto;

  //CONSTRUTOR
  public CobrarCurso(decimal valorCurso, decimal valorMulta, decimal valorDesconto)
  {
    this.ValorCurso = valorCurso;
    this.ValorMulta = valorMulta;
    this.ValorDesconto = valorDesconto;
  }

  //MÉTODO
  private decimal Calculo(decimal valorCurso, decimal valorMulta, decimal valorDesconto)
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