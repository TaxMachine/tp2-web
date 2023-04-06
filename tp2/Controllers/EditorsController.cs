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
    [Route("/")]
    public IActionResult Index()
    {
        return View(bd.CodeEditors.ToList());
    }
    
    [Route("/editors/{id:int}")]
    public IActionResult Details(int id)
    {
        var editor = bd.CodeEditors.SingleOrDefault(e => e.Id == id);
        if (editor == null)
        {
            return View("NotFound", "L'éditeur n'a pas été trouvé!");
        }
        else
        {
            return View(editor);
        }
    }
    
}