using Udemy.QuickBuy.Dominio.Contratos;
using Udemy.QuickBuy.Dominio.Entidades;
using Udemy.QuickBuy.Repositorio.Contexto;

namespace Udemy.QuickBuy.Repositorio.Repositorios
{
	public class ItemPedidoRepositorio : BaseRepositorio<ItemPedido>, IItemPedidoRepositorio
	{
		public ItemPedidoRepositorio(QuickBuyContexto quickBuyContexto) : base(quickBuyContexto)
		{
		}
	}
}
