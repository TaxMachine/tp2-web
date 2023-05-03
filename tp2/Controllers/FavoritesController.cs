using Microsoft.AspNetCore.Mvc;
using tp2.Models;

namespace tp2.Controllers;

/// <summary>
/// Cette classe permet de gérer la page des favoris
/// </summary>
public class FavoritesController : Controller
{
    private BaseDeDonnees bd { get; }
    public FavoritesController(BaseDeDonnees db)
    {
        bd = db;
    }
    
    /// <summary>
    /// Cette méthode permet d'afficher la page des favoris
    /// </summary>
    /// <returns> La page des favoris </returns>
    [HttpGet]
    [Route("/favorites")]
    public IActionResult Favorites()
    {
        var editor = bd.CodeEditors.Where(e => e.Favorite).ToList();
        return View(editor);
    }
    
    /// <summary>
    /// Cette méthode permet de retirer un éditeur des favoris
    /// </summary>
    /// <param name="id"> L'id de l'éditeur de code </param>
    /// <returns> La page des favoris </returns>
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
    
    /// <summary>
    /// Cette méthode permet d'ajouter un éditeur aux favoris
    /// </summary>
    /// <param name="id"> L'id de l'éditeur de code </param>
    /// <returns> La page de l'éditeur </returns>
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
        return Redirect("/");
    }
}