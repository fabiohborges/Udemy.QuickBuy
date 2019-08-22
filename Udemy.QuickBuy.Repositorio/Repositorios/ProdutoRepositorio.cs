using Udemy.QuickBuy.Dominio.Contratos;
using Udemy.QuickBuy.Dominio.Entidades;
using Udemy.QuickBuy.Repositorio.Contexto;

namespace Udemy.QuickBuy.Repositorio.Repositorios
{
	public class ProdutoRepositorio : BaseRepositorio<Produto>, IProdutoRepositorio
	{
		public ProdutoRepositorio(QuickBuyContexto quickBuyContexto) : base(quickBuyContexto)
		{

		}
	}
}
