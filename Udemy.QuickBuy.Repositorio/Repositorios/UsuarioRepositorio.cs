using Udemy.QuickBuy.Dominio.Contratos;
using Udemy.QuickBuy.Dominio.Entidades;
using Udemy.QuickBuy.Repositorio.Contexto;

namespace Udemy.QuickBuy.Repositorio.Repositorios
{
	public class UsuarioRepositorio : BaseRepositorio<Usuario>, IUsuarioRepositorio
	{
		public UsuarioRepositorio(QuickBuyContexto quickBuyContexto) : base(quickBuyContexto)
		{
		}
	}
}
