using System;
using System.Collections.Generic;
using System.Text;
using Udemy.QuickBuy.Dominio.Contratos;
using Udemy.QuickBuy.Dominio.Entidades;

namespace Udemy.QuickBuy.Repositorio.Repositorios
{
	public class ProdutoRepositorio : BaseRepositorio<Produto>, IProdutoRepositorio
	{
		public ProdutoRepositorio()
		{

		}
	}
}
