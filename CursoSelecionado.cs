using FichaDeInscricao;
namespace FichaDeInscricao;


public class CursoSelecionado
{
  public IList<FichaInscricao> Cursos { get; set; }

  public CursoSelecionado()
  {
    Cursos = new List<FichaInscricao>();
  }
}