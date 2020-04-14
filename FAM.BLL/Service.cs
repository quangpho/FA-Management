using FAM.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAM.BLL
{
    public class Service<T> : IService<T> where T : class
    {
        private readonly IRepository<T> _repository;
        public Service(IRepository<T> repository)
        {
            _repository = repository;
        }
        public void Delete(object id)
        {
            _repository.Delete(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _repository.GetAll();
        }

        public T GetOne(object id)
        {
            return _repository.GetOne(id);
        }

        public void Insert(T obj)
        {
            _repository.Insert(obj);
        }

        public void Save()
        {
            _repository.Save();
        }

        public void Update(T obj)
        {
            _repository.Update(obj);
        }
    }
}
