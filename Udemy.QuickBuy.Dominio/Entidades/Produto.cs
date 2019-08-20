namespace Udemy.QuickBuy.Dominio.Entidades
{
	public class Produto : Entidade
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public string Descricao { get; set; }
		public decimal Preco { get; set; }

		public override void Validade()
		{
			LimparMensagensValidacao();

			if (string.IsNullOrEmpty(Nome))
				AdicionarCritica("Nome do Produto não foi informado");
		}
	}
}
