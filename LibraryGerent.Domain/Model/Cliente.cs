namespace LibraryGerent.Domain.Model;

public class Cliente
{
    public int ClienteID { get; set; }
    public string Nome { get; set; }
    public string? Fantasia { get; set; }
    public DateTime? DtCriacao { get; set; }
    public DateTime? DtAtualizacao { get; set; }
}
