using Microsoft.AspNetCore.Mvc;
using System;
using Udemy.QuickBuy.Dominio.Entidades;

namespace Udemy.QuickBuy.Web.Controllers
{
	public class UsuarioController : Controller
    {
		[HttpPost]
		public ActionResult Post()
		{
			try
			{
				return Ok();
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
				throw;
			}
		}

		[HttpPost("VerificarUsuario")]
		public ActionResult VerificarUsuario([FromBody] Usuario usuario)
		{
			try
			{
				if (usuario.Email == "fabiohborges@gmail.com" && usuario.Senha == "1234")
				{
					return Ok(usuario);
				}
				return BadRequest("Usuário ou Senha inválido");
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
				throw;
			}
		}
	}
}
