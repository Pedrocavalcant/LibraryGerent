namespace LibraryGerent.Domain.Model;

public class Genero
{
    public int GeneroID { get; set; }
    public string GeneroNome { get; set; }
    public int? SubGeneroID { get; set; }
    public string? SubGenero { get; set; }
    public DateTime? DtCriacao { get; set; }
    public DateTime? DtAtualizacao { get; set; }
}
