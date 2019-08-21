using Microsoft.EntityFrameworkCore;
using Udemy.QuickBuy.Dominio.Entidades;
using Udemy.QuickBuy.Dominio.ObjetoDeValor;
using Udemy.QuickBuy.Repositorio.Config;

namespace Udemy.QuickBuy.Repositorio.Contexto
{
	public class QuickBuyContexto : DbContext
	{
		public DbSet<Usuario> Usuarios { get; set; }
		public DbSet<Produto> Produtos { get; set; }
		public DbSet<Pedido> Pedidos { get; set; }
		public DbSet<ItemPedido> ItensPedidos { get; set; }
		public DbSet<FormaPagamento> FormaPagamento { get; set; }

		public QuickBuyContexto(DbContextOptions options) : base(options)
		{

		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			//Classes de Mapeamento aqui...
			modelBuilder.ApplyConfiguration(new FormaPagamentoConfiguration());
			modelBuilder.ApplyConfiguration(new ItemPedidoConfiguration());
			modelBuilder.ApplyConfiguration(new PedidoConfiguration());
			modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
			modelBuilder.ApplyConfiguration(new UsuarioConfiguration());

			base.OnModelCreating(modelBuilder);
		}
	}
}
