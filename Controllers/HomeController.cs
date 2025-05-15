using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ecem.Models;

namespace ecem.Controllers;

public class HomeController : Controller
{
    
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult YesAction()
    {
        // "Evet" butonuna basıldığında yönlendirme yapılacak
        return RedirectToAction("ThankYou");
    }

    public IActionResult ThankYou()
    {
        return View();
    }

    
}