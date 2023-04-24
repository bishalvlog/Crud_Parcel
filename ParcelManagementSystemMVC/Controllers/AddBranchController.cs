using Microsoft.AspNetCore.Mvc;
using ParcelManagementSystemMVC.Models;

namespace ParcelManagementSystemMVC.Controllers
{
    public class AddBranchController : Controller
    {
        private readonly  ParcelDbContext _context;

        public AddBranchController (ParcelDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
      
    }
}
