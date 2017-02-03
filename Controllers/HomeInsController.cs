using Microsoft.AspNetCore.Mvc;


public class HomeInsController : Controller
{
    [RouteAttribute("home")]
    [RouteAttribute("home/index")]
    public IActionResult Index()
    {
        return Ok("This is the index of the HomeINSController");
    }
    [RouteAttribute("home/quote")]
    public IActionResult Quote()
    {
        return Ok("This is the Quote of the HomeINSController");
    }

}