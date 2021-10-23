using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreDemo.Models
{
    public class Shop
    {
       public int Id { get; set; }

        [DisplayName("Name of the shop")]
        public string Name { get; set; }
        public List<ShopItem> ShopItems { get; set; }

    }
}
