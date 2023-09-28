using Revisao.Application.AutoMapper.Configuration;
using Revisao.Application.ViewModels;
using Revisao.Domain.Entities;
using Revisao.Domain.Interfaces.Specialized;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Revisao.API.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class CartasController : ControllerBase
	{

		ICartaRepository _service { get; set; }
		public CartasController(ICartaRepository service) {
			_service = service;
		}

		[HttpGet]
		public IList<CartaViewModel> GetCartas()
		{
			return AutoMapperConfig.Map.Map<IList<CartaViewModel>>(_service.GetAll());
		}

		[HttpGet("{id}")]
		public CartaViewModel Get(int id)
		{
			return AutoMapperConfig.Map.Map<CartaViewModel>(_service.GetAll().FirstOrDefault(c => c.ID == id));
		}

		[HttpPost]
		public ActionResult EnviarCarta([FromBody] CartaViewModel carta)
		{
			var new_carta = AutoMapperConfig.Map.Map<Carta>(carta);
			_service.Add(new_carta);
			return Ok();
		}

	}
}
