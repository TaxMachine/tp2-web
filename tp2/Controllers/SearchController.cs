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
    
    [Route("/search")]
    public IActionResult Search(string name)
    {
        var editor = bd.CodeEditors.Where(e => e.Name.Contains(name)).ToList();
        return View(editor);
    }
    
    [Route("/search/{query}")]
    public IActionResult SearchQuery(string query)
    {
        var editor = bd.CodeEditors.Where(e => e.Name.Contains(query)).ToList();
        return View("Search", editor);
    }
}