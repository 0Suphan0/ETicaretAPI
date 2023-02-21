using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaretAPI.Domain.Enitites.Common;

namespace ETicaretAPI.Domain.Enitites
{
    public class Order : BaseEntity
    {
        public int CustomerId { get; set; }
        
        public string Description { get; set; }

        public string Address { get; set; }

        public ICollection<Product> Products { get; set; }

        public Customer Customer { get; set; }

    }
}
