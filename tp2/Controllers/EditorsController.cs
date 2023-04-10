using Microsoft.AspNetCore.Mvc;
using tp2.Models;
using System.Collections.Generic;

namespace tp2.Controllers;

public class EditorsController : Controller
{
    private BaseDeDonnees bd { get; }
    public EditorsController(BaseDeDonnees db)
    {
        bd = db;
    }

    [HttpGet]
    [Route("/editors/{id:int}")]
    public IActionResult Details(int id)
    {
        var editor = bd.CodeEditors.SingleOrDefault(e => e.Id == id);
        return editor == null ? View("NotFound", "L'éditeur n'a pas été trouvé!") : View(editor);
    }
    
    [HttpGet]
    [Route("/search")]
    public IActionResult Search()
    {
        return View("Search");
    }
    
    [HttpPost]
    [Route("/search/query")]
    public IActionResult Query(SearchResults model)
    {
        var editors = bd.CodeEditors.ToList();

        var results = !string.IsNullOrEmpty(model.Criteria.Keywords) 
            ? editors.Where(e => e.Name.ToLower().Contains(model.Criteria.Keywords.ToLower())).ToList() 
            : editors;

        if (model.Criteria.IsTextEditor)
        {
            results = results.Where(e => e.EditorCategory == EditorCategory.TextEditor).ToList();
        }

        if (model.Criteria.IsIDE)
        {
            results = results.Where(e => e.EditorCategory == EditorCategory.IDE).ToList();
        }

        if (model.Criteria.IsCommandLine)
        {
            results = results.Where(e => e.EditorCategory == EditorCategory.Terminal).ToList();
        }

        model.Editors = results.Distinct().ToList();
    
        return View("Query", model);
    }

}