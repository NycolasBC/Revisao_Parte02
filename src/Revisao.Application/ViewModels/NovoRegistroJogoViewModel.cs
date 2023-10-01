using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using WebApplication01.Models.Validations;

namespace MegaSena.Models.Request
{
    public class NovoRegistroJogoViewModel
    {
        [JsonIgnore]
        public int Id { get; set; }

        [Required(ErrorMessage = "É necessário informar um nome")]
        [MinLength(3, ErrorMessage = "É necessário ter no minimo 3 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "É necessário informar um CPF")]
        [CpfValidation]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "É necessário informar o primeiro número")]
        [Range(1, 60, ErrorMessage = "Informe um número de 1 a 60")]
        public int PrimeiroNro { get; set; }

        [Required(ErrorMessage = "É necessário informar o segundo número")]
        [Range(1, 60, ErrorMessage = "Informe um número de 1 a 60")]
        public int SegundoNro { get; set; }

        [Required(ErrorMessage = "É necessário informar o terceiro número")]
        [Range(1, 60, ErrorMessage = "Informe um número de 1 a 60")]
        public int TerceiroNro { get; set; }

        [Required(ErrorMessage = "É necessário informar o quarto número")]
        [Range(1, 60, ErrorMessage = "Informe um número de 1 a 60")]
        public int QuartoNro { get; set; }

        [Required(ErrorMessage = "É necessário informar o quinto número")]
        [Range(1, 60, ErrorMessage = "Informe um número de 1 a 60")]
        public int QuintoNro { get; set; }

        [Required(ErrorMessage = "É necessário informar o sexto número")]
        [Range(1, 60, ErrorMessage = "Informe um número de 1 a 60")]
        public int SextoNro { get; set; }

        [JsonIgnore]
        public DateTime DataJogo { get; set; }
    }
}
