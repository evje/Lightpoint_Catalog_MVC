using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Domain.Entities
{
    public class Good
    {
        public Int32 Id { get; set; }

        public Int32 StoreId { get; set; }

        public String Name { get; set; }

        public String Description { get; set; }
    }
}
