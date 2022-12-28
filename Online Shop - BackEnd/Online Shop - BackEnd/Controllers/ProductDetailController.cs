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
    public class ProductDetailController : Controller
    {
        private readonly AppDbContext _context;

        public ProductDetailController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int? id)
        {
            Product product = await _context.Products
                .Where(m => !m.IsDeleted && m.Id == id)
                .Include(m => m.ProductImages)
                .Include(m => m.ProductSubCategories)
                .ThenInclude(m => m.SubCategory)
                .FirstOrDefaultAsync();

            IEnumerable<SubCategory> subCategories = await _context.SubCategories
                .Where(m => !m.IsDeleted)
                .ToListAsync();

            SubCategory subCategory = await _context.SubCategories
                .Where(m => !m.IsDeleted)
                .FirstOrDefaultAsync();


            ShopVM model = new ShopVM
            {
                Product = product,
                SubCategories = subCategories,
                SubCategory = subCategory
            };

            return View(model);
        }
    }
}
