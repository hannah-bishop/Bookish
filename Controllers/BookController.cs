using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Bookish.Models;
using System;

namespace Bookish.Controllers;

public class BookController : Controller
{
    private readonly ILogger<BookController> _logger;

    public BookController(ILogger<BookController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

}
