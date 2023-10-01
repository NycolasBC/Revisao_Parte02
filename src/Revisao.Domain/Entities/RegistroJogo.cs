using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MegaSena.Models.Request
{
    public class RegistroJogo
    {
        #region Propriedades

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public int PrimeiroNro { get; set; }
        public int SegundoNro { get; set; }
        public int TerceiroNro { get; set; }
        public int QuartoNro { get; set; }
        public int QuintoNro { get; set; }
        public int SextoNro { get; set; }
        public DateTime DataJogo { get; set; }

        #endregion

        #region Construtores

        public RegistroJogo(int id, string nome, string cpf, int primeiroNro, int segundoNro, int terceiroNro, int quartoNro, int quintoNro, int sextoNro, DateTime dataJogo)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            PrimeiroNro = primeiroNro;
            SegundoNro = segundoNro;
            TerceiroNro = terceiroNro;
            QuartoNro = quartoNro;
            QuintoNro = quintoNro;
            SextoNro = sextoNro;
            DataJogo = dataJogo;
        }

        public RegistroJogo() { }

        #endregion
    }
}
