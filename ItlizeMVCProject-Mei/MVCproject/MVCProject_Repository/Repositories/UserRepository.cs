using System.Data.Entity;
using MVCProject_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCProject_Repository.Repositories
{
    public interface IUser : IRepository<User>
    {
    }
    public class UserRepo : IUser
    {
        private DbContext context;

        public UserRepo(DbContext context)
        {
            this.context = context;
        }

        public IQueryable<User> Entities => throw new NotImplementedException();

        private List<User> dbSet => context.Set<User>().ToList();

        public IQueryable<User> DataSet(string s)
        {
            throw new NotImplementedException();
        }

        public void Delete(User entity)
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

        public IEnumerable<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(User entity)
        {
            throw new NotImplementedException();
        }

        public void remove(User entity)
        {
            // dbSet.Find(entity);
        }

        public void Remove(User entity)
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
    }
}