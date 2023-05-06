using Microsoft.AspNetCore.Mvc;

namespace tp3.Controllers;

/// <summary>
/// Cette classe permet de gérer les erreurs 404
/// </summary>
public class NotFoundController : Controller
{
    
    /// <summary>
    /// Cette méthode permet d'afficher la page 404
    /// </summary>
    /// <returns> La page 404 </returns>
    [Route("/NotFound")]
    public new IActionResult NotFound()
    {
        return View("NotFound", "404 - Page not found!");
    }
}