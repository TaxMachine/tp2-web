using Microsoft.AspNetCore.Mvc;
using tp3.Models;

namespace tp3.Controllers;

/// <summary>
/// Cette classe permet de gérer la suppression d'un éditeur de code
/// </summary>
public class GestionEditorsController : Controller
{
    private BaseDeDonnees bd { get; }
    public GestionEditorsController(BaseDeDonnees db)
    {
        bd = db;
    }
    
    
    /// <summary>
    /// Cette méthode permet d'afficher la page de suppression d'un éditeur de code
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpGet]
    [Route("/gestioneditors/delete/{id:int}")]
    public IActionResult Get(int id)
    {
        var editor = bd.CodeEditors.SingleOrDefault(e => e.Id == id);
        return editor == null ? View("NotFound", "L'éditeur n'a pas été trouvé!") : View("Delete", editor);
    }
    
    /// <summary>
    /// Cette méthode permet de supprimer un éditeur de code
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("/gestioneditors/delete/{id:int}")]
    public IActionResult Delete(int id)
    {
        var editor = bd.CodeEditors.SingleOrDefault(e => e.Id == id);
        if (editor == null)
        {
            return View("NotFound", "L'éditeur n'a pas été trouvé!");
        }
        bd.CodeEditors.Remove(editor);
        return Redirect("/");
    }
}