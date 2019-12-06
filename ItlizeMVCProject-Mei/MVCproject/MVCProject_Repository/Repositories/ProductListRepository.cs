using System.Data.Entity;
using MVCProject_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCProject_Repository.Repositories
{
    public interface IProductList : IRepository<ProductList>
    {
    }
    public class ProductListRepository : IProductList
    {
        private DbContext context;

        public ProductListRepository(DbContext context)
        {
            this.context = context;
        }

        private IDbSet<ProductList> dbSet => context.Set<ProductList>();
        public IQueryable<ProductList> Entities => dbSet;

        public ProductList Find(int v)
        {
            var a = dbSet.Find(v);
            return a;
        }

        public string Search(string searchString)
        {
            string s = "";
            var list = from p in dbSet select p;
            if (!String.IsNullOrEmpty(searchString))
            {
                list = list.Where(product => product.ProductName.Contains(searchString));
                foreach (var product in list)
                {
                    s += product.ProductName + " ";
                }
            }
            //var result = from product in list
            //             where product.Product_Name == searchString
            //             select product;
            return s;
        }

        public IQueryable<ProductList> DataSet(string filter)
        {
            if (!String.IsNullOrEmpty(filter))
            {
                var filterSet = from p in dbSet select p;
                filterSet = dbSet.Where(product => product.ProductName.Contains(filter));
                return filterSet;
            }
            return dbSet;
        }

        public void Remove(ProductList entity)
        {
            dbSet.Find(entity);
        }

        public IEnumerable<ProductList> find(ProductList v)
        {
            throw new NotImplementedException();
        }

        public void remove(ProductList entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductList> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(ProductList entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(ProductList entity)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}