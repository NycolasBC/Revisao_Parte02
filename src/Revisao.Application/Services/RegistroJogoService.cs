using AutoMapper;
using MegaSena.Models.Request;
using Revisao.Application.Interfaces;
using Revisao.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Application.Services
{
    public class RegistroJogoService : IRegistroJogoService
    {
        #region Propriedades e Construtores

        private readonly IRegistroJogoRepository _registroJogoRepository;
        private IMapper _mapper;

        public RegistroJogoService(IRegistroJogoRepository registroJogoRepository, IMapper mapper)
        {
            _registroJogoRepository = registroJogoRepository;
            _mapper = mapper;
        }

        #endregion

        #region Funções

        public void AdicionarRegistro(NovoRegistroJogoViewModel registro)
        {
            var novoRegistro = _mapper.Map<RegistroJogo>(registro);
            _registroJogoRepository.AdicionarRegistro(novoRegistro);
        }

        public List<RegistroJogoViewModel> ObterTodos()
        {
            return _mapper.Map<List<RegistroJogoViewModel>>(_registroJogoRepository.ObterTodos());
        }

        #endregion
    }
}
