namespace FichaDeInscricao;


class Program
{

  static void Main(string[] args)
  {
    System.Console.WriteLine("Calculando idade");
    System.Console.WriteLine("Insira a data de nascimento: ");
    var dataNascimento = Console.ReadLine();
    System.Console.WriteLine($"Data de nascimento inserida: {Convert.ToDateTime(dataNascimento)}");
    FichaInscricao f = new FichaInscricao("", "", "", Convert.ToDateTime(dataNascimento), 0, 0, 0);
    System.Console.WriteLine(f.Idade);
  }
}

