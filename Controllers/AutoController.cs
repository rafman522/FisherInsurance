using FisherInsurance.Models;
using Microsoft.AspNetCore.Mvc;
using System;

public class AutoController : Controller
{
    public IActionResult Index()
    {
        //return Ok("This is the index of the AutoController");
        return View();
    }
    public IActionResult Quote()
    {
        //return Ok("This is the Quote of the AutoController");
        Quote quote = new Quote 
        {
            Id = 345,

            Product = "Auto Insurance",

            ExpireDate = DateTime.Now.AddDays(45),

            Price = 45.00M

        };
        return View(quote);
    }

}