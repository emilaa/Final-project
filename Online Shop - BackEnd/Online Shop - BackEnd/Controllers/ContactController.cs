using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Online_Shop___BackEnd.Data;
using Online_Shop___BackEnd.Models;
using Online_Shop___BackEnd.ViewModels;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Shop___BackEnd.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;

        public ContactController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            Contact contact = await _context.Contacts.Where(m => !m.IsDeleted).FirstOrDefaultAsync();

            ContactVM model = new ContactVM
            {
                Contact = contact
            };

            return View(model);
        }
    }
}
