using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BasicProject.Models;

namespace BasicProject.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Quizzes()
    {
        return View();
    }

    public IActionResult Progress()
    {
        return View();
    }

    public IActionResult Quiz1()
    {
        return View();
    }

    public IActionResult Quiz2()
    {
        return View();
    }

    public IActionResult Quiz3()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}