using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreDemo.Models
{
    public class ShopItem
    {
        public int Id { get; set; } // ID by default yra Primary Key. Kitu atveju reikia nurodyti [KEY]
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public Shop Shop { get; set; }
        public int? ShopId { get; set; }
        public List<ShopItemItemTag> ShopItemItemTags {get;set;}
    }
}
