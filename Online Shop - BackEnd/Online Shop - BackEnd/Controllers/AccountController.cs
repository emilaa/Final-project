using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Online_Shop___BackEnd.Data;
using Online_Shop___BackEnd.Models;
using Online_Shop___BackEnd.ViewModels;
using Online_Shop___BackEnd.ViewModels.AccountViewModels;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Shop___BackEnd.Controllers
{
    public class AccountController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public AccountController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Register()
        {
            Login_Register login_Registers = await _context.Login_Registers.Where(m => !m.IsDeleted).FirstOrDefaultAsync();

            RegisterVM model = new RegisterVM
            {
                Login_Registers = login_Registers
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterVM registerVM)
        {
            if (!ModelState.IsValid)
            {
                Login_Register login_Registers = await _context.Login_Registers.Where(m => !m.IsDeleted).FirstOrDefaultAsync();

                RegisterVM model = new RegisterVM
                {
                    Login_Registers = login_Registers
                };

                return View(model);
            }

            if (ModelState.IsValid)
            {
                Login_Register login_Registers = await _context.Login_Registers.Where(m => !m.IsDeleted).FirstOrDefaultAsync();

                RegisterVM model = new RegisterVM
                {
                    Login_Registers = login_Registers
                };

                AppUser user = new AppUser
                {
                    Name = registerVM.Name,
                    Surname = registerVM.Surname,
                    UserName = registerVM.Username,
                    Email = registerVM.Email
                };

                IdentityResult result = await _userManager.CreateAsync(user, registerVM.Password);

                return View(model);
            }

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Login()
        {
            Login_Register login_Registers = await _context.Login_Registers.Where(m => !m.IsDeleted).FirstOrDefaultAsync();

            LoginVM model = new LoginVM
            {
                Login_Registers = login_Registers
            };

            return View(model);
        }
    }
}
