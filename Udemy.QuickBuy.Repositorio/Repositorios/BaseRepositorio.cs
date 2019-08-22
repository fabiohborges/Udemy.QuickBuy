using System;
using System.Collections.Generic;
using System.Linq;
using Udemy.QuickBuy.Dominio.Contratos;
using Udemy.QuickBuy.Repositorio.Contexto;

namespace Udemy.QuickBuy.Repositorio.Repositorios
{
	public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class
	{
		protected readonly QuickBuyContexto QuickBuyContexto;

		public BaseRepositorio(QuickBuyContexto quickBuyContexto)
		{
			this.QuickBuyContexto = quickBuyContexto;
		}

		public void Adicionar(TEntity entity)
		{
			this.QuickBuyContexto.Set<TEntity>().Add(entity);
			this.QuickBuyContexto.SaveChanges();
		}

		public void Atualizar(TEntity entity)
		{
			this.QuickBuyContexto.Set<TEntity>().Update(entity);
			this.QuickBuyContexto.SaveChanges();
		}

		public void Remover(TEntity entity)
		{
			//this.QuickBuyContexto.Set<TEntity>().Remove(entity);
			this.QuickBuyContexto.Remove(entity);
			this.QuickBuyContexto.SaveChanges();
		}

		public TEntity ObterPorId(int id)
		{
			return this.QuickBuyContexto.Set<TEntity>().Find(id);
		}

		public IEnumerable<TEntity> ObterTodos()
		{
			return this.QuickBuyContexto.Set<TEntity>().ToList();
		}

		public void Dispose()
		{
			this.QuickBuyContexto.Dispose();
		}
	}
}
