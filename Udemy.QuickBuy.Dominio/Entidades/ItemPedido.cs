using System;
using System.Collections.Generic;
using System.Text;

namespace Udemy.QuickBuy.Dominio.Entidades
{
	public class ItemPedido : Entidade
	{
		public int Id { get; set; }
		public int ProdutoId { get; set; }
		public int Quantidade { get; set; }

		public override void Validade()
		{
			LimparMensagensValidacao();

			if (ProdutoId == 0)
				AdicionarCritica("Não foi possível identificar qual a referência do Produto");

			if (Quantidade == 0)
				AdicionarCritica("Quantidade não foi informado");
		}
	}
}
