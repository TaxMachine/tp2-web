using Microsoft.AspNetCore.Mvc;
using tp2.Models;

namespace tp2.Controllers;

/// <summary>
/// Cette classe permet de gérer la page d'accueil
/// </summary>
public class HomeController : Controller
{
    private BaseDeDonnees bd { get; }
    public HomeController(BaseDeDonnees db)
    {
        bd = db;
    }
    
    /// <summary>
    /// Cette méthode permet d'afficher la page d'accueil
    /// </summary>
    /// <returns> La page d'accueil </returns>
    [Route("/")]
    public IActionResult Index()
    {
        return View(bd.CodeEditors.ToList());
    }
}