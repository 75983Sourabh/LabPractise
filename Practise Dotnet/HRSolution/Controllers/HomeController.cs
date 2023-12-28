using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HRSolution.Models;

namespace HRSolution.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    [HttpGet]
    public IActionResult Register()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Register(string firstname,string lastname,string birthdayDate,string emailAddress+string phoneNumber+ string dropdown)
    {
    Console.WriteLine(firstname+" "+lastname+" "+ birthdayDate+" "+emailAddress+" "+(string)phoneNumber+" "+ (string)dropdown);
        return View();
    }

    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }

[HttpPost]
    public IActionResult Login(string username,string password)
    {
        Console.WriteLine(username+" "+password);
        if(username=="Sourabh" && password=="Blackpearl"){
            return this.RedirectToAction("Welcome");
        }
        return View();
    }



public IActionResult Welcome()
    {
        return View();
    }





    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
