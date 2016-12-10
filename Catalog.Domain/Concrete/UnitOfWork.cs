using System;
using Catalog.Domain.Abstract;
using Catalog.Domain.Entities;

namespace Catalog.Domain.Concrete
{
    public class UnitOfWork : IDisposable
    {
        private EfDbContext context = new EfDbContext();
        private GenericRepository<Store> storeRepository;
        private GenericRepository<Good> goodRepository;

        public GenericRepository<Store> StoreRepository
        {
            get
            {

                if (this.storeRepository == null)
                {
                    this.storeRepository = new GenericRepository<Store>(context);
                }
                return storeRepository;
            }
        }

        public GenericRepository<Good> GoodRepository
        {
            get
            {

                if (this.goodRepository == null)
                {
                    this.goodRepository = new GenericRepository<Good>(context);
                }
                return goodRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}