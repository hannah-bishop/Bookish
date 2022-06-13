using Microsoft.AspNetCore.Mvc;
using Bookish.Models;
using Bookish.Services;

namespace Bookish.Controllers;

public class MemberController : Controller
{
    private readonly ILogger<MemberController> _logger;
    private MemberService _memberService;

    public MemberController(ILogger<MemberController> logger)
    {
        _logger = logger;
        _memberService = new MemberService();
    }

    public IActionResult Index()
    {
        List<Member> members = _memberService.GetAllMembers();
        return View(members);
    }

}
