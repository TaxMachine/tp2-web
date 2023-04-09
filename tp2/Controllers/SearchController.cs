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
        if (!string.IsNullOrEmpty(model.Criteria.Keywords))
        {
            editors = editors.Where(e => e.Name.ToLower().Contains(model.Criteria.Keywords.ToLower())).ToList();
        }
        if (model.Criteria.IsTextEditor)
        {
            editors = editors.Where(e => e.EditorCategory == 
                                         (model.Criteria.IsTextEditor is true 
                                             ? EditorCategory.TextEditor 
                                             : null)).ToList();
        }
        if (model.Criteria.IsIDE)
        {
            editors = editors.Where(e => e.EditorCategory == 
                                         (model.Criteria.IsIDE is true 
                                             ? EditorCategory.IDE 
                                             : null)).ToList();
        }
        if (model.Criteria.IsCommandLine)
        {
            editors = editors.Where(e => e.EditorCategory ==
                                         (model.Criteria.IsCommandLine is true 
                                             ? EditorCategory.Terminal 
                                             : null)).ToList();
        }
        model.Editors = editors;
        return View("Query", model);
    }

}