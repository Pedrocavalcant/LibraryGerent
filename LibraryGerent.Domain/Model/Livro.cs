namespace LibraryGerent.Domain.Model;

public class Livro
{
    public Guid LivroID { get; set; }
    public string Titulo { get; set; }
    public int GeneroID { get; set; }
    public string? Autor { get; set; }
    public decimal Preco { get; set; }
    public int Estoque { get; set; }
    public DateTime? DtCriacao { get; set; }
    public DateTime? DtAtualizacao { get; set; }
}
