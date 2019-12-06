

using System.Data.Entity;
using MVCProject_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCProject_Repository.Repositories
{
    public interface IRepository<T> where T:class
    {

        IEnumerable<T> find(T v);
        void remove(T entity);

        IQueryable<T> Entities { get; }
        T Find(int v);
        string Search(string s);
        IQueryable<T> DataSet(string s);
        IEnumerable<T> GetAll();
        void Insert(T entity);
        void Delete(T entity);
        void Remove(T entity);
        void SaveChanges();
    }
}
