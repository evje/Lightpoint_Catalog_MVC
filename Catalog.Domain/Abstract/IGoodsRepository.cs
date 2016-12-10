using System;
using System.Collections.Generic;
using Catalog.Domain.Entities;

namespace Catalog.Domain.Abstract
{
    public interface IGoodsRepository : IDisposable
    {
        IEnumerable<Good> GetGoods();

        IEnumerable<Good> GetGoodsByStoreId(Int32 storeId);

        Good GetGoodById(Int32 goodId);

        void InsertGood(Good good);

        void DeleteGood(Int32 goodId);

        void UpdateGood(Good good);

        void Save();

    }
}