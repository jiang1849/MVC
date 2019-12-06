using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MVCProject_DAL;
namespace MVCProject_Repository.Repositories
{
    public interface ISearchtblCategory : IRepository<Category>
    {
        IEnumerable<Category> GetListCategory();
    }

    public interface ISearchtblSubCategory : IRepository<SubCategory>
    {
        IEnumerable<SubCategory> getSubCategoBasedOnCatego(int categoryID);
    }

    public class SearchRepo : ISearchtblCategory, ISearchtblSubCategory
    {
        DbContext Context;

        public SearchRepo(DbContext context)
        {
            this.Context = context;
        }

        public IQueryable<Category> Entities => throw new NotImplementedException();

        IQueryable<SubCategory> IRepository<SubCategory>.Entities => throw new NotImplementedException();


        private List<Category> CategoriesList => Context.Set<Category>().ToList();
        private List<SubCategory> subCategoriesList => Context.Set<SubCategory>().ToList();

        IQueryable<Category> IRepository<Category>.Entities => throw new NotImplementedException();

        public IEnumerable<Category> GetListCategory()
        {

            return CategoriesList;
        }

        public IEnumerable<SubCategory> getSubCategoBasedOnCatego(int categoryID)
        {
            return subCategoriesList.Where(p => p.SubCategoryID == categoryID);
        }

        public IEnumerable<Category> find(Category v)
        {
            var filteredList = CategoriesList.Where(current => current.CategoryName == v.CategoryName);
            return filteredList;
        }

        public IEnumerable<SubCategory> find(SubCategory v)
        {
            var filteredList = subCategoriesList.Where(current => current.SubCategoryName == v.SubCategoryName);
            return filteredList;
        }

        void IRepository<Category>.remove(Category entity)
        {
            throw new NotImplementedException();
        }

        Category IRepository<Category>.Find(int v)
        {
            throw new NotImplementedException();
        }

        string IRepository<Category>.Search(string s)
        {
            throw new NotImplementedException();
        }

        IQueryable<Category> IRepository<Category>.DataSet(string s)
        {
            throw new NotImplementedException();
        }

        void IRepository<SubCategory>.remove(SubCategory entity)
        {
            throw new NotImplementedException();
        }

        SubCategory IRepository<SubCategory>.Find(int v)
        {
            throw new NotImplementedException();
        }

        string IRepository<SubCategory>.Search(string s)
        {
            throw new NotImplementedException();
        }

        IQueryable<SubCategory> IRepository<SubCategory>.DataSet(string s)
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

        IEnumerable<SubCategory> IRepository<SubCategory>.GetAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(SubCategory entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(SubCategory entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(SubCategory entity)
        {
            throw new NotImplementedException();
        }
    }
}