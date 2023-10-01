using AutoMapper;
using MegaSena.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Application.AutoMapper
{
	public class ApplicationToDomain : Profile
	{
		public ApplicationToDomain()
		{
			CreateMap<RegistroJogoViewModel, RegistroJogo>()
			   .ConstructUsing(q => new RegistroJogo(q.Id, q.Nome, q.Cpf, q.PrimeiroNro, q.SegundoNro, q.TerceiroNro, q.QuartoNro, q.QuintoNro, q.SegundoNro, q.DataJogo));

			CreateMap<NovoRegistroJogoViewModel, RegistroJogo>()
			   .ConstructUsing(q => new RegistroJogo(q.Id, q.Nome, q.Cpf, q.PrimeiroNro, q.SegundoNro, q.TerceiroNro, q.QuartoNro, q.QuintoNro, q.SegundoNro, q.DataJogo));

		}
	}
}
