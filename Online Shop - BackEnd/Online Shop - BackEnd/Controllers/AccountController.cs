using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Online_Shop___BackEnd.Data;
using Online_Shop___BackEnd.Models;
using Online_Shop___BackEnd.ViewModels;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Shop___BackEnd.Controllers
{
    public class AccountController : Controller
    {
        private readonly AppDbContext _context;

        public AccountController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            Login_Register login_Registers = await _context.Login_Registers.Where(m => !m.IsDeleted).FirstOrDefaultAsync();

            AccountVM model = new AccountVM
            {
                Login_Registers = login_Registers
            };

            return View(model);
        }
    }
}
