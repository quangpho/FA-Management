using DAL;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace FAM.Repository
{
	public class Repository<T> : IRepository<T> where T : class
	{
		private FAMContext ctx;
		private DbSet<T> table;
		public Repository()
		{
			ctx = new FAMContext();
			table = ctx.Set<T>();
		}
		public void Delete(object id)
		{
			var found = table.Find(id);
			table.Remove(found);
		}

		public IEnumerable<T> GetAll()
		{
			return table.ToList();
		}

		public T GetOne(object id)
		{
			return table.Find(id);
		}

		public void Insert(T obj)
		{
			table.Add(obj);
		}

		public void Save()
		{
			ctx.SaveChanges();
		}

		public void Update(T obj)
		{
			table.Attach(obj);
			ctx.Entry(obj).State = EntityState.Modified;
		}
	}
}
