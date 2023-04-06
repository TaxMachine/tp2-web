using Microsoft.AspNetCore.Mvc;
using tp2.Models;

namespace tp2.Controllers;

public class SearchController : Controller
{
    private BaseDeDonnees bd { get; }
    
    public SearchController(BaseDeDonnees db)
    {
        bd = db;
    }
    
    public IActionResult Search(string name)
    {
        var editor = bd.CodeEditors.Where(e => e.Name.Contains(name)).ToList();
        return View(editor);
    }
}