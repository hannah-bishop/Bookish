using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Bookish.Models;

namespace Bookish.Controllers;

public class AddCopyController : Controller
{
    private readonly ILogger<AddCopyController> _logger;

    public AddCopyController(ILogger<AddCopyController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {

        return View();
    }

}
