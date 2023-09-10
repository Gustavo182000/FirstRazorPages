using System.ComponentModel.DataAnnotations;

namespace RazorPages.Models
{
    public class Filme
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = "";
        [Display(Name = "Data de Lançamento")]
        [DataType(DataType.Date)]
        public DateTime DataLancamento { get; set; }
        public string Genero { get; set; } = "";
        public decimal Preco { get; set; }
    }
}
