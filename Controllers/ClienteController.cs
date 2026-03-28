using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyWebApp.Models;

namespace MyWebApp.Controllers
{
    public class ClienteController : Controller
    {
        private readonly AppDbContext _context;

        public ClienteController(AppDbContext context)
        {
            _context = context;
        }

        // GET: /Cliente
        public async Task<IActionResult> Index()
        {
            var cliente = await _context.Clientes.FirstOrDefaultAsync();

            return View(cliente);
        }
    }
}