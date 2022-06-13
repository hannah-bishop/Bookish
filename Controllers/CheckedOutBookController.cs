using Microsoft.AspNetCore.Mvc;
using Bookish.Models;
using Bookish.Services;

namespace Bookish.Controllers;

public class CheckedOutBookController : Controller
{
    private readonly ILogger<CheckedOutBookController> _logger;
    private CheckedOutBookService _checkedOutBookService;

    public CheckedOutBookController(ILogger<CheckedOutBookController> logger)
    {
        _logger = logger;
        _checkedOutBookService = new CheckedOutBookService();
    }

    public IActionResult Index()
    {
        CheckedOutBook checkedOutBook = _checkedOutBookService.GetCheckedOutBookById(1);
        return View(checkedOutBook);
    }

}
