using Microsoft.AspNetCore.Mvc;

[RouteAttribute("home")]
public class HomeInsController : Controller
{
    
    public IActionResult Index()
    {
        return Ok("This is the index of the HomeINSController");
    }
    [RouteAttribute("quote")]
    public IActionResult Quote()
    {
        return Ok("This is the Quote of the HomeINSController");
    }

}