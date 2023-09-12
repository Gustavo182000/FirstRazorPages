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
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = true)]

        [Required(ErrorMessage = "O preço é obrigatório")]
        public decimal Preco { get; set; }


        public int Relevancia { get; set; }
    }
}
