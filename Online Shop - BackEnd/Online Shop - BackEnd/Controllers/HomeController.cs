﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Online_Shop___BackEnd.Data;
using Online_Shop___BackEnd.Models;
using Online_Shop___BackEnd.Services;
using Online_Shop___BackEnd.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Shop___BackEnd.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        private readonly LayoutService _layoutService;

        public HomeController(AppDbContext context, LayoutService layoutService)
        {
            _context = context;
            _layoutService = layoutService;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Banner> banners = await _context.Banners.Where(m => !m.IsDeleted).ToListAsync();
            IEnumerable<Product> products = await _context.Products
                .Where(m => !m.IsDeleted)
                .Include(m => m.ProductImages)
                .Include(m => m.ProductSubCategories)
                .ThenInclude(m => m.SubCategory)
                .Take(7)
                .ToListAsync();

            HomeVM model = new HomeVM
            {
                Banners = banners,
                Products = products
            };

            return View(model);
        }
    }
}
