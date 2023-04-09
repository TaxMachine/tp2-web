using Microsoft.AspNetCore.Mvc;

namespace tp2.Controllers;

public class NotFoundController : Controller
{
    [Route("/NotFound")]
    public new IActionResult NotFound()
    {
        return View("NotFound", "404 - Page not found!");
    }
}