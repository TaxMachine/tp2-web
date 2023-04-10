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
    
    [HttpGet]
    [Route("/favorites/remove/{id:int}")]
    public virtual IActionResult Remove(int id)
    {
        var editor = bd.CodeEditors.SingleOrDefault(e => e.Id == id);
        if (editor == null)
        {
            return View("NotFound", "L'éditeur n'a pas été trouvé!");
        }
        editor.Favorite = false;
        return RedirectToAction("Favorites");
    }
    
    [HttpGet]
    [Route("/editors/addfavorite/{id:int}")]
    public IActionResult AddFavorite(int id)
    {
        var editor = bd.CodeEditors.SingleOrDefault(e => e.Id == id);
        if (editor == null)
        {
            return View("NotFound", "L'éditeur n'a pas été trouvé!");
        }
        editor.Favorite = !editor.Favorite;
        return Redirect("/editors/" + id);
    }
}