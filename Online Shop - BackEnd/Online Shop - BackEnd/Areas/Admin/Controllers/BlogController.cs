using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Online_Shop___BackEnd.Data;
using Online_Shop___BackEnd.Helpers;
using Online_Shop___BackEnd.Models;
using Online_Shop___BackEnd.ViewModels.ProductViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using Microsoft.EntityFrameworkCore;
using Online_Shop___BackEnd.ViewModels.BlogViewModels;

namespace Online_Shop___BackEnd.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _environment;

        public BlogController(AppDbContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        public async Task<IActionResult> Index(int page = 1, int take = 3)
        {
            List<Blog> blogs = await _context.Blogs
                .Where(m => !m.IsDeleted)
                .Include(m => m.BlogImages)
                .OrderByDescending(m => m.Id)
                .Skip((page * take) - take)
                .Take(take)
                .ToListAsync();

            List<BlogListVM> mapDatas = GetMapDatas(blogs);

            int count = await GetPageCount(take);

            Paginate<BlogListVM> result = new Paginate<BlogListVM>(mapDatas, page, count);

            return View(result);
        }

        private async Task<int> GetPageCount(int take)
        {
            int blogCount = await _context.Blogs.Where(m => !m.IsDeleted).CountAsync();

            return (int)Math.Ceiling((decimal)blogCount / take);
        }

        private List<BlogListVM> GetMapDatas(List<Blog> blogs)
        {
            List<BlogListVM> blogList = new List<BlogListVM>();

            foreach (var blog in blogs)
            {
                BlogListVM newBlog = new BlogListVM
                {
                    Id = blog.Id,
                    Title = blog.Title,
                    Image = blog.BlogImages.FirstOrDefault()?.Name
                };

                blogList.Add(newBlog);
            }

            return blogList;
        }

        [HttpGet]
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return BadRequest();

            Blog blog = await _context.Blogs
                .Where(m => !m.IsDeleted && m.Id == id)
                .Include(m => m.BlogImages)
                .Include(m => m.BlogSubCategories)
                .ThenInclude(m => m.SubCategory)
                .FirstOrDefaultAsync();

            BlogSubCategory category = await _context.BlogSubCategories
                .Where(m => m.BlogId == id && m.SubCategory.CategoryId == 6)
                .Include(m => m.SubCategory)
                .FirstOrDefaultAsync();

            if (blog == null) return NotFound();

            BlogDetailVM blogDetail = new BlogDetailVM
            {
                Id = blog.Id,
                Images = blog.BlogImages,
                Title = blog.Title,
                Description = blog.Description,
                Category = category.SubCategory.Name,
            };

            return View(blogDetail);
        }
    }
}
