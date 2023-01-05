using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Online_Shop___BackEnd.Data;
using Online_Shop___BackEnd.Helpers;
using Online_Shop___BackEnd.Models;
using Online_Shop___BackEnd.ViewModels.CategoryViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Shop___BackEnd.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _environment;

        public CategoryController(AppDbContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        public async Task<IActionResult> Index(int page = 1, int take = 3)
        {
            List<SubCategory> categories = await _context.SubCategories
                .Where(m => !m.IsDeleted)
                .Include(m => m.Category)
                .OrderByDescending(m => m.Id)
                .Skip((page * take) - take)
                .Take(take)
                .ToListAsync();

            List<CategoryListVM> mapDatas = GetMapDatas(categories);

            int count = await GetPageCount(take);

            Paginate<CategoryListVM> result = new Paginate<CategoryListVM>(mapDatas, page, count);

            return View(result);
        }

        private async Task<int> GetPageCount(int take)
        {
            int categoryCount = await _context.SubCategories.Where(m => !m.IsDeleted).CountAsync();

            return (int)Math.Ceiling((decimal)categoryCount / take);
        }

        private List<CategoryListVM> GetMapDatas(List<SubCategory> categories)
        {
            List<CategoryListVM> categoryList = new List<CategoryListVM>();

            foreach (var category in categories)
            {
                CategoryListVM newCategory = new CategoryListVM
                {
                    Id = category.Id,
                    Category = category.Category.Name,
                    SubCategory = category.Name
                };

                categoryList.Add(newCategory);
            }

            return categoryList;
        }
    }
}
