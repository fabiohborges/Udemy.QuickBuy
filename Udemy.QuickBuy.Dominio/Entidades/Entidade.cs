using System.Collections.Generic;
using System.Linq;

namespace Udemy.QuickBuy.Dominio.Entidades
{
	public abstract class Entidade
	{
		public List<string> _mensagensValidacao { get; set; }
		private List<string> mensagensValidacao
		{
			get { return _mensagensValidacao ?? (_mensagensValidacao = new List<string>()); }
		}

		public abstract void Validade(); 

		protected bool EhValidado
		{
			get { return !mensagensValidacao.Any(); }
		}

		protected void LimparMensagensValidacao()
		{
			mensagensValidacao.Clear();
		}

		protected void AdicionarCritica(string mensagem)
		{
			mensagensValidacao.Add(mensagem);
		}
	}
}
