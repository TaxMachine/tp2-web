using Microsoft.AspNetCore.Mvc;
using tp2.Models;
using System.Collections.Generic;

namespace tp2.Controllers;

/// <summary>
/// Cette classe permet de gérer les éditeurs de code
/// </summary>
public class EditorsController : Controller
{
    private BaseDeDonnees bd { get; }
    public EditorsController(BaseDeDonnees db)
    {
        bd = db;
    }

    /// <summary>
    /// Cette méthode permet d'afficher la page d'accueil
    /// </summary>
    /// <param name="id"> L'id de l'éditeur de code </param>
    /// <returns> La page d'accueil </returns>
    [HttpGet]
    [Route("/editors/{id:int}")]
    public IActionResult Details(int id)
    {
        var editor = bd.CodeEditors.SingleOrDefault(e => e.Id == id);
        return editor == null ? View("NotFound", "L'éditeur n'a pas été trouvé!") : View(editor);
    }
    
    /// <summary>
    /// Cette méthode permet d'afficher la page de recherche
    /// </summary>
    /// <returns> La page de recherche </returns>
    [HttpGet]
    [Route("/search")]
    public IActionResult Search()
    {
        var editors = bd.CodeEditors.ToList();
        var model = new SearchResults
        {
            Editors = editors,
            Criteria = new SearchCriteria()
        };
        return View("Search", model);
    }
    
    /// <summary>
    /// Cette méthode permet de faire une recherche parmi les éditeurs de code
    /// </summary>
    /// <param name="model"></param>
    /// <returns> La page de recherche avec les résultats </returns>
    [HttpPost]
    [Route("/search")]
    public IActionResult Query(SearchResults model)
    {
        var editors = bd.CodeEditors.ToList();

        var results = !string.IsNullOrEmpty(model.Criteria.Keywords) 
            ? editors.Where(e => e.Name.ToLower().Contains(model.Criteria.Keywords.ToLower())).ToList() 
            : editors;

        /*
         * J'avais essayé de faire un if/else if/else mais c'était trop long et trop répétitif
         * J'ai donc décidé d'utiliser un switch expression qui est plus court et plus lisible
         */
        results = (model.Criteria.IsTextEditor, model.Criteria.IsIDE, model.Criteria.IsCommandLine) switch
        {
            (true, true, true) => results.Where(e =>
                    e.EditorCategory is EditorCategory.TextEditor or EditorCategory.IDE or EditorCategory.Terminal)
                .ToList(),
            
            (true, true, false) => results
                .Where(e => e.EditorCategory is EditorCategory.TextEditor or EditorCategory.IDE)
                .ToList(),
            
            (true, false, true) => results
                .Where(e => e.EditorCategory is EditorCategory.TextEditor or EditorCategory.Terminal)
                .ToList(),
            
            (true, false, false) => results
                .Where(e => e.EditorCategory is EditorCategory.TextEditor)
                .ToList(),
            
            (false, true, true) => results
                .Where(e => e.EditorCategory is EditorCategory.IDE or EditorCategory.Terminal)
                .ToList(),
            
            (false, true, false) => results
                .Where(e => e.EditorCategory is EditorCategory.IDE)
                .ToList(),
            
            (false, false, true) => results
                .Where(e => e.EditorCategory is EditorCategory.Terminal)
                .ToList(),
            
            (false, false, false) => results
                .Where(e => e.EditorCategory is EditorCategory.TextEditor or EditorCategory.IDE or EditorCategory.Terminal)
                .ToList()
        };

        if (model.Criteria.MinimumRating > 0)
        {
            results = results.Where(e => e.PersonalRating >= model.Criteria.MinimumRating).ToList();
        }
        
        if (model.Criteria.MaximumRating > 0)
        {
            results = results.Where(e => e.PersonalRating <= model.Criteria.MaximumRating).ToList();
        }

        model.Editors = results.Distinct().ToList();
        
        return View("Search", model);
    }
    
    
}