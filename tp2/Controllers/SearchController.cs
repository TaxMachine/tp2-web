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
    public IActionResult Search()
    {
        return View();
    }

    [HttpPost]
    [Route("/search/query")]
    public IActionResult Query([FromForm] CodeEditor body)
    {
        IQueryCollection qs = HttpContext.Request.Query;
        var result = new List<CodeEditor>();
        var name = body.Name;
        var category = body.EditorCategory.ToString();
        var favorite = body.Favorite;
        if (name != null)
        {
            var editor = bd.CodeEditors.Where(e => e.Name.Contains(name)).ToList();
            editor.ForEach(e => result.Add(e));
        }
        if (category != null)
        {
            var editor = bd.CodeEditors.Where(e => e.EditorCategory == new CodeEditor().ConvertCategory(category)).ToList();
            editor.ForEach(e => result.Add(e));
        }

        if (!favorite)
            return result.Count == 0 ? View("NotFound", "Aucun éditeur n'a été trouvé!") : View("Search", result);
        {
            var editor = bd.CodeEditors.Where(e => e.Favorite).ToList();
            editor.ForEach(e => result.Add(e));
        }
        Console.WriteLine(result.Count);
        return result.Count == 0 ? View("NotFound", "Aucun éditeur n'a été trouvé!") : View("Search", result);
    }
}