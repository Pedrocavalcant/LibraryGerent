using LibraryGerent.Domain.Enums;

namespace LibraryGerent.Domain.Model;

public class Movimento
{
    public int MovimentacaoID { get; set; }
    public int? ClienteID { get; set; }
    public int? Quantidade { get; set; }
    public decimal? Total { get; set; }
    public Sentido? Sentido { get; set; } // 1 para entrada, -1 para saída
    public DateTime? DtCriacao { get; set; }
    public int? LivroID { get; set; }
    }
