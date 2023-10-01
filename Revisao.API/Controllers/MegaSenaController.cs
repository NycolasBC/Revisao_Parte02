using MegaSena.Models.Request;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Revisao.Application.Interfaces;
using System;
using WebApplicationList01.Controllers;

namespace MegaSena.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MegaSenaController : PrincipalController
    {
        #region Propriedades e Construtores

        private readonly IRegistroJogoService _registroJogoService;

        public MegaSenaController(IRegistroJogoService registroJogoService)
        {
            _registroJogoService = registroJogoService;
        }

        #endregion

        #region Métodos Crud

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_registroJogoService.ObterTodos());
            }
            catch
            {
                return BadRequest("Nenhum jogo salvo");
            }
        }

        [HttpPost(Name = "Adicionar")]
        public IActionResult Post([FromBody] NovoRegistroJogoViewModel novoRegistro)
        {
            if (!ModelState.IsValid)
            {
                return ApiBadRequestResponse(ModelState);
            }

            if (ValidacaoNumeroDaSorte(novoRegistro))
            {
                return BadRequest("Os números devem ser diferentes um do outro");
            }

            _registroJogoService.AdicionarRegistro(novoRegistro);

            return ApiResponse(novoRegistro, "Jogo registrado com sucesso.");
        }

        #endregion

        #region Validação Número da sorte

        private bool ValidacaoNumeroDaSorte(NovoRegistroJogoViewModel registroJogoViewModel)
        {
            int[] arrayDeJogos = new int[]
            {
                registroJogoViewModel.PrimeiroNro,
                registroJogoViewModel.SegundoNro,
                registroJogoViewModel.TerceiroNro,
                registroJogoViewModel.QuartoNro,
                registroJogoViewModel.QuintoNro,
                registroJogoViewModel.SextoNro
            };

            HashSet<int> numerosVistos = new HashSet<int>();

            foreach (int numero in arrayDeJogos)
            {
                if (numerosVistos.Contains(numero))
                {
                    return true;
                }
                else
                {
                    numerosVistos.Add(numero);
                }
            }

            return false;
        }

        #endregion

    }
}
