using Revisao.Domain.Entities;
using Revisao.Domain.Interfaces.Specialized;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Application.Services
{
	public class CartaService : ServiceBase<Carta>, ICartaService
	{
		ICartaRepository _cartaRepository { get; set; }
		public CartaService(ICartaRepository repository)
			:base(repository)
		{
			_cartaRepository = repository;
		}

		public IList<Carta> GetCartasIdadeMaiorQue(int idade)
		{
			return _cartaRepository.GetCartasIdadeMaiorQue(idade);
		}

		public IList<Carta> GetCartasIdadeMenorQue(int idade)
		{
			return _cartaRepository.GetCartasIdadeMenorQue(idade);

		}
	}
}
