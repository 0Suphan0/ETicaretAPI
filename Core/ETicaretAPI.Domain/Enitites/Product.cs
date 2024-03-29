﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaretAPI.Domain.Enitites.Common;

namespace ETicaretAPI.Domain.Enitites
{
    public class Product : BaseEntity
    {
        // These properties match the table column
        public string Name { get; set; }

        public int Stock { get; set; }

        public float Price { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
