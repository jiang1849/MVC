using System.Data.Entity;
using MVCProject_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCProject_Repository.Repositories
{
    public interface IProductProperty : IRepository<ProductProperty>
    {
    }
    public class ProductPropertyRepository : IProductProperty 
    {
        private DbContext context;

        public ProductPropertyRepository(DbContext context)
        {
            this.context = context;

        }

        public IQueryable<ProductProperty> Entities => throw new NotImplementedException();

        DbSet<ProductProperty> entities => context.Set<ProductProperty>();

        public IQueryable<ProductProperty> DataSet(string s)
        {
            throw new NotImplementedException();
        }

        public void Delete(ProductProperty entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
            context.SaveChanges();
        }

        public IEnumerable<ProductProperty> find(ProductProperty v)
        {
            throw new NotImplementedException();
        }

        public ProductProperty Find(int v)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductProperty> GetAll()
        {
            return entities.AsEnumerable();
        }

        public void Insert(ProductProperty entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Add(entity);
            context.SaveChanges();
        }

        public void Remove(ProductProperty entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
        }

        public void remove(ProductProperty entity)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        public string Search(string s)
        {
            throw new NotImplementedException();
        }
    }
}