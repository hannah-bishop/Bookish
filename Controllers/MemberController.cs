using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Bookish.Models;

namespace Bookish.Controllers;

public class MemberController : Controller
{
    private readonly ILogger<MemberController> _logger;

    public MemberController(ILogger<MemberController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Member member = new Member()
        {
            Id = 3,
            Name = "John Smith",
            Address = "1 London Road, SE14 5TE",
            Email = "john-smith@gmail.co.uk"
        };
        return View(member);
    }

}
