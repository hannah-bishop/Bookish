using Microsoft.AspNetCore.Mvc;
using Bookish.Models;
using Bookish.Services;

namespace Bookish.Controllers;

public class CopyController : Controller
{
    private readonly ILogger<CopyController> _logger;
    private CopyService _copyService;

    public CopyController(ILogger<CopyController> logger)
    {
        _logger = logger;
        _copyService = new CopyService();
    }

    public IActionResult Index()
    {
        List<Copy> copies = _copyService.GetAllCopies();
        return View(copies);
    }

}
