using EfCoreDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreDemo.Dtos
{
    public class ShopItemCreate
    {
        public string Name { get; set; }
        public List<Shop> Shops { get; set; }
        public int ShopId { get; set; }
    }
}
