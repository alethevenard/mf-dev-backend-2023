using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_dev_backend_2023.Models
{
    [Table("Jogos")]
    public class Jogo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public String Loja { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public int NumDeJogadores { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public int Idade { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string Mecanicas { get; set; }


        [Required(ErrorMessage = "Campo obrigatório")]
        public string Temas { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public int Valor { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public int PeriodoDeLocacao { get; set; }
    }
}
