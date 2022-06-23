namespace FichaDeInscricao;


class Program
{

  static void Main(string[] args)
  {
    System.Console.WriteLine("Calculando idade");
    FichaInscricao f = new FichaInscricao();
    System.Console.WriteLine("Insira o ano de nascimento");
    f.DataNascimento = Convert.ToInt32(Console.ReadLine());
    f.ExibirDados();


  }
}



