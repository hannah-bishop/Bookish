using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Bookish.Models;

namespace Bookish.Controllers;

public class AddBookController : Controller
{
    private readonly ILogger<AddBookController> _logger;

    public AddBookController(ILogger<AddBookController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {

        return View();
    }

}
