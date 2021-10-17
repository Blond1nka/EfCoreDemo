using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreDemo.Models
{
    public class ShopItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime Created { get; set; }
        public Shop Shop { get; set; }
        public List<ShopItemItemTag> ShopItemItemTags {get;set;}
    }
}
