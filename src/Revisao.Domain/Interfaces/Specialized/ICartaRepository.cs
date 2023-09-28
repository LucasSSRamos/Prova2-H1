using Revisao.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Domain.Interfaces.Specialized
{
	public interface ICartaRepository : IRepositoryBase<Carta>
	{
		public IList<Carta> GetCartasIdadeMaiorQue(int idade);
		public IList<Carta> GetCartasIdadeMenorQue(int idade);
	}
}
