using FichaDeInscricao;
namespace FichaDeInscricao;
public static class CadastroScreen
{
  public static void Iniciar(CursoSelecionado cursos)
  {

    Console.Clear();
    Console.WriteLine("Digite o nome do aluno: ");
    var nome = Console.ReadLine();

    Console.WriteLine("Digite o curso do aluno: ");
    var curso = Console.ReadLine();

    Console.WriteLine("Digite a escolaridade do aluno: ");
    var escolaridade = Console.ReadLine();

    Console.WriteLine("Digite o valor do curso: ");
    var valorCurso = int.Parse(Console.ReadLine()!);

    Console.WriteLine("Digite o valor do desconto: ");
    var valorDesconto = int.Parse(Console.ReadLine()!);

    Console.WriteLine("Digite o valor da multa: ");
    var valorMulta = int.Parse(Console.ReadLine()!);

    System.Console.WriteLine("Insira a data de nascimento: ");
    var dataNascimento = Console.ReadLine();
    System.Console.WriteLine($"Data de nascimento inserida: {Convert.ToDateTime(dataNascimento)}");

    CobrarCurso custo = new CobrarCurso(valorCurso, valorMulta, valorDesconto);
    cursos.Cursos.Add(new FichaInscricao(nome, curso, escolaridade, Convert.ToDateTime(dataNascimento), valorCurso, valorDesconto, valorMulta));

    FichaInscricao ficha = new FichaInscricao(nome, curso, escolaridade, Convert.ToDateTime(dataNascimento), valorCurso, valorDesconto, valorMulta);
    // System.Console.WriteLine(ficha.Idade);

    if (ficha.ValorDesconto == 0)
    {
      Console.WriteLine(FormatacaoTexto.Formatacao(ficha.Nome, ficha.Curso, ficha.ValorCurso));
    }
    else if (ficha.ValorDesconto > 0 && ficha.Idade < 18)
    {
      Console.WriteLine(FormatacaoTexto.Formatacao(ficha.Nome, ficha.Curso, ficha.ValorCurso, ficha.ValorDesconto, ficha.Idade, custo.Resultado));
    }
    else if (ficha.ValorDesconto > 0)
    {
      Console.WriteLine(FormatacaoTexto.Formatacao(ficha.Nome, ficha.Curso, ficha.ValorCurso, ficha.ValorDesconto));
    }

    Console.ReadLine();
  }

}
