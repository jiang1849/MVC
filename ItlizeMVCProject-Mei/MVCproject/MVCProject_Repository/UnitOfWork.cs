using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MVCProject_DAL;
using MVCProject_Repository.Repositories;

namespace MVCProject_Repository
{



    interface Iunitofwork
    {
        IUser users { get; }
        IProperty manu { get; }

        ICategory prodtype { get; }
        IProductList products { get; }

    }

    public class UnitofWork : DbContext, Iunitofwork
    {
        public IUser users => throw new NotImplementedException();

        public IProperty manu => throw new NotImplementedException();

        public ICategory prodtype => throw new NotImplementedException();

        public IProductList products => throw new NotImplementedException();

        public class ApplicationContext : DbContext
        {
            private readonly DbContext context;

            public ApplicationContext(DbContext context)
            {
                this.context = context;
            }

            public ILogin logins => new LoginRepository(context);
            public ICategory category => new CategoryRepository(context);
            public ISubCategory subcategory => new SubCategoryRepository(context);
            public IProperty property => new PropertyRepository(context);
            public IProductList productlist => new ProductListRepository(context);
            public IProductProperty productproperty => new ProductPropertyRepository(context);


        }
    }