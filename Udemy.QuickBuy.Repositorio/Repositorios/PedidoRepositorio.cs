using Udemy.QuickBuy.Dominio.Contratos;
using Udemy.QuickBuy.Dominio.Entidades;
using Udemy.QuickBuy.Repositorio.Contexto;

namespace Udemy.QuickBuy.Repositorio.Repositorios
{
	public class PedidoRepositorio : BaseRepositorio<Pedido>, IPedidoRepositorio
	{
		public PedidoRepositorio(QuickBuyContexto quickBuyContexto) : base(quickBuyContexto)
		{
		}
	}
}
