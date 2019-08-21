using System;
using System.Collections.Generic;
using System.Linq;
using Udemy.QuickBuy.Dominio.ObjetoDeValor;

namespace Udemy.QuickBuy.Dominio.Entidades
{
	public class Pedido : Entidade
	{
		public int Id { get; set; }
		public DateTime DataPedido { get; set; }
		public int UsuarioId { get; set; }
		public virtual Usuario Usuario { get; set; }
		public DateTime DataPrevisaoEntrega { get; set; }
		public string CEP { get; set; }
		public string Estado { get; set; }
		public string Cidade { get; set; }
		public string EnderecoCompleto { get; set; }
		public string NumeroEndereco { get; set; }
		public int FormaPagamentoId { get; set; }
		public virtual FormaPagamento FormaPagamento { get; set; }

		/// <summary>
		/// Pedido deve ter pelo um item de pedido
		/// ou muitos itens de pedidos
		/// </summary>
		public virtual ICollection<ItemPedido> ItensPedido { get; set; }

		public override void Validade()
		{
			LimparMensagensValidacao();

			if (!ItensPedido.Any())
				AdicionarCritica("Pedido não pode ficar sem Item de Pedido");

			if (string.IsNullOrEmpty(CEP))
				AdicionarCritica("Cep deve estar preenchido");

			if (FormaPagamentoId == 0)
				AdicionarCritica("Não foi informado a forma de pagamento");
		}
	}
}
