using System.Data.Entity;
using MVCProject_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCProject_Repository.Repositories
{
    public interface ICategory : IRepository<Category>
    {
    }
    public class CategoryRepository : ICategory
    {
        private DbContext context;

        public CategoryRepository(DbContext context)
        {
            this.context = context;
        }

        private DbSet<Category> dbset => context.Set<Category>();

        public IQueryable<Category> entities => throw new NotImplementedException();

        public IQueryable<Category> Entities => throw new NotImplementedException();

        public Category Find(int v)
        {
            var a = dbset.Find(v);
            return a;
        }

        public void remove(Category entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> find(Category v)
        {
            throw new NotImplementedException();
        }

        public string Search(string s)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Category> DataSet(string s)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(Category entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Category entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(Category entity)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}