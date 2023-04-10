using Microsoft.AspNetCore.Mvc;
using tp2.Models;

namespace tp2.Controllers;

public class HomeController : Controller
{
    private BaseDeDonnees bd { get; }
    public HomeController(BaseDeDonnees db)
    {
        bd = db;
    }
    
    [Route("/")]
    public IActionResult Index()
    {
        return View(bd.CodeEditors.ToList());
    }
}