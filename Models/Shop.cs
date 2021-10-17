﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreDemo.Models
{
    public class Shop
    {
       public int Id { get; set; }
        public string Name { get; set; }
        public List<ShopItem> ShopItems { get; set; }

    }
}
