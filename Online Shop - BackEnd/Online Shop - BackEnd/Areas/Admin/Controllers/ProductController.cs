using Microsoft.AspNetCore.Mvc;

namespace Online_Shop___BackEnd.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
