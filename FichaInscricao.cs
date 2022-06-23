namespace FichaDeInscricao;

//CLASSE
public class FichaInscricao
{
  public string Nome { get; set; }
  public int Idade { get; set; }
  public string Curso { get; set; }
  public string Escolaridade { get; set; }
  public int DataNascimento { get; set; }
  public double ValorCurso { get; set; }
  public double ValorDesconto { get; set; }
  public double ValorMulta { get; set; }

  //CONSTRUTOR
  public FichaInscricao()
  {
    var dataNascimento = 0;

  }
  public FichaInscricao(string nome, string curso, string escolaridade, int dataNascimento, double valorCurso, double valorDesconto, double valorMulta)
  {
    Nome = nome;
    Curso = curso;
    Escolaridade = escolaridade;
    DataNascimento = dataNascimento;
    ValorCurso = valorCurso;
    ValorDesconto = valorDesconto;
    ValorMulta = valorMulta;
  }

  //Métodos
  public void ExibirDados()
  {
    System.Console.WriteLine("Ano de nascimento: " + this.DataNascimento);
    int idade = this.CalcularIdade();
    System.Console.WriteLine("A idade é: " + idade);
  }
  private int CalcularIdade()
  {
    DateTime data = DateTime.Now;
    int ano = data.Year;
    int idade = ano - this.DataNascimento;
    return idade;

  }
}