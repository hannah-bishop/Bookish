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
        List<CheckedOutBook> checkedOutBooks = _checkedOutBookService.GetAllCheckedOutBooks();
        return View(checkedOutBooks);
    }

}
