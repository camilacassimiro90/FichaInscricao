namespace FichaDeInscricao;
public class FichaInscricao
{

  public string Nome { get; set; }
  public int Idade { get; set; }
  public string Curso { get; set; }
  public string Escolaridade { get; set; }
  public DateTime DataNascimento { get; set; }
  public double ValorCurso { get; set; }
  public double ValorDesconto { get; set; }
  public double ValorMulta { get; set; }

  public FichaInscricao(string nome, string curso, string escolaridade, DateTime dataNascimento, double valorCurso, double valorDesconto, double valorMulta)
  {
    Nome = Nome;
    Curso = curso;
    Escolaridade = escolaridade;
    DataNascimento = dataNascimento;
    ValorCurso = valorCurso;
    ValorDesconto = valorDesconto;
    ValorMulta = valorMulta;
  }
}