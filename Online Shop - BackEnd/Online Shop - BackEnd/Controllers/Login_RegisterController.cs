using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Online_Shop___BackEnd.Data;
using Online_Shop___BackEnd.Models;
using Online_Shop___BackEnd.ViewModels;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Shop___BackEnd.Controllers
{
    public class Login_RegisterController : Controller
    {
        private readonly AppDbContext _context;

        public Login_RegisterController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            Login_Register login_Registers = await _context.Login_Registers.Where(m => !m.IsDeleted).FirstOrDefaultAsync();

            Login_RegisterVM model = new Login_RegisterVM
            {
                Login_Registers = login_Registers
            };

            return View(model);
        }
    }
}
