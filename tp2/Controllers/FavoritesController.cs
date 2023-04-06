using Microsoft.AspNetCore.Mvc;
using tp2.Models;

namespace tp2.Controllers;

public class FavoritesController : Controller
{
    private BaseDeDonnees bd { get; }
    public FavoritesController(BaseDeDonnees db)
    {
        bd = db;
    }
    
    // GET
    public IActionResult Favorites()
    {
        var editor = bd.CodeEditors.Where(e => e.Favorite).ToList();
        return View(editor);
    }
}