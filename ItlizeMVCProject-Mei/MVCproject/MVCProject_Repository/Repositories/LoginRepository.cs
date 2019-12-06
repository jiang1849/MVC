using System.Data.Entity;
using MVCProject_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCProject_Repository.Repositories
{
    public interface ILogin : IRepository<Login>
    { 
    }
    public class LoginRepository : ILogin
    {
        private DbContext context;

        public LoginRepository(DbContext context)
        {
            this.context = context;
        }

        public IQueryable<User> Entities => throw new NotImplementedException();

        private List<User> dbSet => context.Set<User>().ToList();

        IQueryable<Login> IRepository<Login>.Entities => throw new NotImplementedException();

        public IQueryable<User> DataSet(string s)
        {
            throw new NotImplementedException();
        }

        public void Delete(Login entity)
        {
            throw new NotImplementedException();
        }

        /*
         * this method will query through a given list and find a row based on either the username or email and return
         * the row to the user as IEnumerable<tblUser>
         * return: IEnumerable<tblUser> - rows for all the users that matches either the username or email
         * arg: take a tblUser
         */
        public IEnumerable<User> find(User c)
        {
            var filteredRows = dbSet.Where(p => p.FirstName == c.FirstName || p.Address == c.Address);

            return filteredRows;

        }

        public User find(int v)
        {
            throw new NotImplementedException();
        }

        public User Find(int v)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Login> find(Login v)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Login> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(Login entity)
        {
            throw new NotImplementedException();
        }

        public void remove(User entity)
        {
            // dbSet.Find(entity);
        }

        public void remove(Login entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(Login entity)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public string Search(string s)
        {
            throw new NotImplementedException();
        }

        IQueryable<Login> IRepository<Login>.DataSet(string s)
        {
            throw new NotImplementedException();
        }

        Login IRepository<Login>.Find(int v)
        {
            throw new NotImplementedException();
        }
    }
}