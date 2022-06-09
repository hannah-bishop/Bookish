using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Bookish.Models;

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
        Book book = new Book()
        {
            Id = 3,
            Title = "Harry Potter",
            Author = "J.K. Rowling",
            CoverImageUrl = @"https://static.wikia.nocookie.net/harrypotter/images/7/7b/Harry01english.jpg",
            Blurb = "Harry Potter is a series of seven fantasy novels written by British author J. K. Rowling. The novels chronicle the lives of a young wizard, Harry Potter, and his friends Hermione Granger and Ron Weasley, all of whom are students at Hogwarts School of Witchcraft and Wizardry."
        };
        return View(book);
    }

}
