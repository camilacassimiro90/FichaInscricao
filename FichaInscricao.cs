namespace fichaDeInscricao;


public class FichaInscricao
{
  public string Nome { get; set; }
  public int Idade { get; set; }
  public string Curso { get; set; }
  public string Escolaridade { get; set; }

  public DateTime DataNascimento { get; set; }
  public double ValorCurso { get; set; }

  public double ValorDesconto { get; set; }

  public double valorMulta { get; set; }
}