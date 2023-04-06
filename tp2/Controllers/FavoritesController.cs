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
    [Route("/favorites")]
    public IActionResult Favorites()
    {
        var editor = bd.CodeEditors.Where(e => e.Favorite).ToList();
        return View(editor);
    }
    
    [Route("/favorites/remove/{id:int}")]
    public IActionResult Remove(int id)
    {
        var editor = bd.CodeEditors.SingleOrDefault(e => e.Id == id);
        if (editor == null)
        {
            return View("NotFound", "L'éditeur n'a pas été trouvé!");
        }
        else
        {
            editor.Favorite = false;
            return RedirectToAction("Favorites");
        }
    }
}