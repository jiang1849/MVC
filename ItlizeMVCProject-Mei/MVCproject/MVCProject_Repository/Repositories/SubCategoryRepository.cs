using System.Data.Entity;
using MVCProject_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCProject_Repository.Repositories
{
    public interface ISubCategory : IRepository<SubCategory>
    {
    }
    public class SubCategoryRepository : ISubCategory
    {
        private DbContext context;

        public SubCategoryRepository(DbContext context)
        {
            this.context = context;

        }

        public IQueryable<SubCategory> Entities => throw new NotImplementedException();

        DbSet<SubCategory> entities => context.Set<SubCategory>();

        public IQueryable<SubCategory> DataSet(string s)
        {
            throw new NotImplementedException();
        }

        public void Delete(SubCategory entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
            context.SaveChanges();
        }

        public IEnumerable<SubCategory> find(SubCategory v)
        {
            throw new NotImplementedException();
        }

        public SubCategory Find(int v)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SubCategory> GetAll()
        {
            return entities.AsEnumerable();
        }

        public void Insert(SubCategory entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Add(entity);
            context.SaveChanges();
        }

        public void Remove(SubCategory entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
        }

        public void remove(SubCategory entity)
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