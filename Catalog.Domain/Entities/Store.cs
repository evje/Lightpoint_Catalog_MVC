using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Domain.Entities
{
    public class Store
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]

        public Int32 Id { get; set; }

        public String Name { get; set; }

        public String Address { get; set; }

        public String Mode { get; set; }

        public virtual ICollection<Good> Goods { get; set; }

    }
}
