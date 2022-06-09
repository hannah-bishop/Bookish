using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Bookish.Models;

namespace Bookish.Controllers;

public class UpdateBookController : Controller
{
    private readonly ILogger<UpdateBookController> _logger;

    public UpdateBookController(ILogger<UpdateBookController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {

        return View();
    }

}
