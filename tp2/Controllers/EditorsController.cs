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
        return View(bd.CodeEditors);
    }
    
    [Route("/search")]
    public IActionResult Search(string name)
    {
        var editor = bd.CodeEditors.Where(e => e.Name.Contains(name)).ToList();
        return View(editor);
    }

    [Route("/favorie")]
    public IActionResult Favorites()
    {
        var editor = bd.CodeEditors.Where(e => e.Favorite).ToList();
        return View(editor);
    }
}