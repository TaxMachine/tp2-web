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
        var model = new SearchResults
        {
            Criteria = new SearchCriteria
            {
                IsCommandLine = true,
                IsTextEditor = true,
                IsIDE = true
            },
            Editors = bd.CodeEditors.ToList()
        };
        return View("Search");
    }
    
    [HttpPost]
    [Route("/search/query")]
    public IActionResult Query(SearchResults model)
    {
        var editors = bd.CodeEditors.ToList();
        Console.WriteLine("text editor :" + model.Criteria.IsTextEditor);
        Console.WriteLine("ide :" + model.Criteria.IsIDE);
        Console.WriteLine("command line :" + model.Criteria.IsCommandLine);
        Console.WriteLine("editors: " + editors.Count);
        if (!string.IsNullOrEmpty(model.Criteria.Keywords))
        {
            editors = editors.Where(e => e.Name.ToLower().Contains(model.Criteria.Keywords.ToLower())).ToList();
        }
        Console.WriteLine("keywords check: " + editors.Count);
        if (model.Criteria.IsTextEditor)
        {
            editors = editors.Where(e => e.EditorCategory == 
                                         (model.Criteria.IsTextEditor is true 
                                             ? EditorCategory.TextEditor 
                                             : null)).ToList();
        }
        Console.WriteLine("text editor check: " + editors.Count);
        if (model.Criteria.IsIDE)
        {
            editors = editors.Where(e => e.EditorCategory == 
                                         (model.Criteria.IsIDE is true 
                                             ? EditorCategory.IDE 
                                             : null)).ToList();
        }
        Console.WriteLine("ide check: " + editors.Count);
        if (model.Criteria.IsCommandLine)
        {
            editors = editors.Where(e => e.EditorCategory ==
                                         (model.Criteria.IsCommandLine is true 
                                             ? EditorCategory.Terminal 
                                             : null)).ToList();
        }
        Console.WriteLine("command line check: " + editors.Count);
        model.Editors = editors;
        return View("Query", model);
    }

}