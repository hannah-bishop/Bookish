using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Bookish.Models;

namespace Bookish.Controllers;

public class LibrarianOptionsController : Controller
{
    private readonly ILogger<LibrarianOptionsController> _logger;

    public LibrarianOptionsController(ILogger<LibrarianOptionsController> logger)
    {
        _logger = logger;
    }
      public IActionResult Index()
    {
        return View();
    }

}
