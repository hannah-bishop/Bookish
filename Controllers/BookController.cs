using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Bookish.Models;
using Bookish.Services;
using System;
using Bookish.Models.Request;

namespace Bookish.Controllers;

public class BookController : Controller
{
    private readonly ILogger<BookController> _logger;
    private BookService _bookService;

    public BookController(ILogger<BookController> logger)
    {
        _logger = logger;
        _bookService = new BookService();
    }

    [HttpGet]
    public IActionResult Index()
    {
        List<Book> books = _bookService.GetAllBooks();
        return View("Books", books);
    }

    [HttpPost("/Book")]
    public IActionResult CreateBook([FromForm] CreateBookRequest newBook)
    {
        Book book = _bookService.CreateBook(newBook);
        return View("Book", book);
    }

    [HttpGet("/Book/CreateBook")]

    public IActionResult CreateBookForm()
    {
        return View("CreateBook");
    }
}
