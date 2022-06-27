namespace FichaDeInscricao;

public static class FormatacaoTexto
{
  public static string Formatacao(string nome, string curso, decimal valorCurso)
  {
    return
     @$"Nome: {nome}
Curso: {curso}
Valor do curso: {valorCurso}";
  }
  public static string Formatacao(string nome, string curso, decimal valorCurso, decimal valorDesconto)
  {
    return
  @$"Nome: {nome}
Curso: {curso}
Valor do curso: {valorCurso}
Valor do desconto: {valorDesconto}";
  }
  public static string Formatacao(string nome, string curso, decimal valorCurso, decimal valorDesconto, int idade)
  {
    return
    @$"Nome: {nome}
Curso: {curso}
Valor do curso: {valorCurso}
Valor do desconto: {valorDesconto}
Idade: {idade}";
  }
}