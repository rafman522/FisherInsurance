using Microsoft.AspNetCore.Mvc;
using System;
using FisherInsurance.Models;

[RouteAttribute("home")]
public class HomeInsController : Controller
{
    
    public IActionResult Index()
    {
        //return Ok("This is the index of the HomeINSController");
        return View();
    }
    [RouteAttribute("quote")]
    public IActionResult Quote()
    {
        //return Ok("This is the Quote of the HomeINSController");
        Quote quote = new Quote 
        {
            Id = 343,

            Product = "Home Insurance",

            ExpireDate = DateTime.Now.AddDays(45),

            Price = 33.00M

        };
        return View(quote);
    }

}