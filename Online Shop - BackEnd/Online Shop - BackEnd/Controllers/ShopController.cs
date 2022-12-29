using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Online_Shop___BackEnd.Data;
using Online_Shop___BackEnd.Models;
using Online_Shop___BackEnd.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Shop___BackEnd.Controllers
{
    public class ShopController : Controller
    {
        private readonly AppDbContext _context;

        public ShopController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.count = await _context.Products.Where(m => !m.IsDeleted).CountAsync();

            IEnumerable<Banner> banners = await _context.Banners.Where(m => !m.IsDeleted).ToListAsync();
            IEnumerable<Product> products = await _context.Products
                .Where(m => !m.IsDeleted)
                .Include(m => m.ProductImages)
                .Include(m => m.ProductSubCategories)
                .ThenInclude(m => m.SubCategory)
                .Take(4)
                .ToListAsync();
            IEnumerable<SubCategory> subCategories = await _context.SubCategories
                .Where(m => !m.IsDeleted)
                .ToListAsync();

            ShopVM model = new ShopVM
            {
                Banners = banners,
                Products = products,
                SubCategories = subCategories,
            };

            return View(model);
        }

        public async Task<IActionResult> ShowMore(int skip)
        {
            IEnumerable<Product> products = await _context.Products
                .Where(m => !m.IsDeleted)
                .Include(m => m.ProductImages)
                .Include(m => m.ProductSubCategories)
                .ThenInclude(m => m.SubCategory)
                .Skip(skip)
                .Take(4)
                .ToListAsync();

            ShopVM model = new ShopVM
            {
                Products = products
            };

            return PartialView("_ProductsPartial", model);
        }
    }
}
