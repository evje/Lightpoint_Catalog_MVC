using System;
using System.Collections.Generic;
using Catalog.Domain.Entities;

namespace Catalog.Domain.Abstract
{
    public interface IStoresRepository : IDisposable
    {
        IEnumerable<Store> GetStores();

        Store GetStoreById(Int32 storeId);

        void InsertStore(Store store);

        void DeleteStore(Int32 storeId);

        void UpdateStore(Store store);

        void Save();
    }
}