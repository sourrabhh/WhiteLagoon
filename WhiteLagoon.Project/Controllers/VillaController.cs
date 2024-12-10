using Microsoft.AspNetCore.Mvc;
using WhiteLagoon.Infrastructure.Data;

namespace WhiteLagoon.Project.Controllers
{
    public class VillaController : Controller
    {
        private readonly ApplicationDbContext _db;
        
        
        // DI for DB Context
        public VillaController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var villas = _db.Villas_Tbl.ToList();

            return View(villas);
        }
    }
}
