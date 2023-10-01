using MegaSena.Models.Request;
using Newtonsoft.Json;
using Revisao.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Data.Repositories
{
    public class RegistroJogoRepository : IRegistroJogoRepository
    {
        #region - Atributos e Construtor

        private readonly string _registrosCaminhoArquivo;

        public RegistroJogoRepository()
        {
            _registrosCaminhoArquivo = Path.Combine(Directory.GetCurrentDirectory(), "FileJsonData", "registros.json");
        }

        #endregion

        #region - Funções do arquivo
        private List<RegistroJogo> LerRegistrosDoArquivo()
        {
            if (!System.IO.File.Exists(_registrosCaminhoArquivo))
            {
                return new List<RegistroJogo>();
            }

            string json = System.IO.File.ReadAllText(_registrosCaminhoArquivo);
            return JsonConvert.DeserializeObject<List<RegistroJogo>>(json);
        }

        private int ObterProximoCodigoDisponivel()
        {
            IEnumerable<RegistroJogo> registros = LerRegistrosDoArquivo();
            if (registros.Any())
            {
                return registros.Max(c => c.Id) + 1;
            }
            else
            {
                return 1;
            }
        }

        private void EscreverRegistrosNoArquivo(List<RegistroJogo> registros)
        {
            string json = JsonConvert.SerializeObject(registros);
            System.IO.File.WriteAllText(_registrosCaminhoArquivo, json);
        }

        #endregion

        #region - Funções de repositorio

        public void AdicionarRegistro(RegistroJogo registro)
        {
            List<RegistroJogo> registroJogos = LerRegistrosDoArquivo();

            int proximoCodigo = ObterProximoCodigoDisponivel();

            RegistroJogo registros = new RegistroJogo()
            {
                Id          = proximoCodigo,
                Nome        = registro.Nome,   
                Cpf         = registro.Cpf,
                PrimeiroNro = registro.PrimeiroNro,
                SegundoNro  = registro.SegundoNro,
                TerceiroNro = registro.TerceiroNro,
                QuartoNro   = registro.QuartoNro,
                QuintoNro   = registro.QuintoNro,
                SextoNro    = registro.SextoNro,
                DataJogo    = DateTime.Now
            };

            registroJogos.Add(registros);
            EscreverRegistrosNoArquivo(registroJogos);
        }

        public List<RegistroJogo> ObterTodos()
        {
            List<RegistroJogo> registros = LerRegistrosDoArquivo();
            return registros;
        }

        #endregion    
    }
}
