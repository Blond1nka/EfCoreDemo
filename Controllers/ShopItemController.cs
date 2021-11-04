using EfCoreDemo.Data;
using EfCoreDemo.Dtos;
using EfCoreDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreDemo.Controllers
{
    public class ShopItemController : Controller
    {
        private readonly DataContext _context;

        public ShopItemController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Add()
        {
            var shopItem = new ShopItemCreate();
            return View(shopItem);
        }

        [HttpPost]
        public IActionResult Add(ShopItemCreate shopItemCreate)
        {
            var mappedEntity = new ShopItem()
            {
                Name = shopItemCreate.Name,
                ShopId = shopItemCreate.ShopId
            };                                         //mapping
            
            _context.ShopItems.Add(mappedEntity);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
