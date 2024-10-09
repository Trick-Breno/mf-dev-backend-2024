using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_dev_backend_2024.Models
{
    [Table("Veiculos")]
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar Nome!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar placa!")]
        public string Placa { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar ano de fabricação!")]
        public int AnoFabricacao { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar ano modelo!")]
        public int AnoModelo { get; set; }
    }
}
