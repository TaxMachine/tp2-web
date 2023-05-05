using Microsoft.AspNetCore.Mvc;
using tp2.Models;

namespace tp2.Controllers;

public class GestionEditorsController : Controller
{
    private BaseDeDonnees bd { get; }
    public GestionEditorsController(BaseDeDonnees db)
    {
        bd = db;
    }
    
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
        return RedirectToAction("Index", "Home");
    }
}