using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAM.Repository
{
	public interface IRepository<T> where T : class
	{
		IEnumerable<T> GetAll();
		T GetOne(object id);
		void Insert(T obj);
		void Update(T obj);
		void Delete(object id);
		void Save();
	}
}
