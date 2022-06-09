using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Bookish.Models;

namespace Bookish.Controllers;

public class DeleteBookController : Controller
{
    private readonly ILogger<DeleteBookController> _logger;

    public DeleteBookController(ILogger<DeleteBookController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {

        return View();
    }

}
