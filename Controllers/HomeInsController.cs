using Microsoft.AspNetCore.Mvc;

//[Route("api/Home")]
public class HomeInsController : Controller
{
    public IActionResult Index()
    {
        return Ok("This is the index of the HomeINSController");
    }
    public IActionResult Quote()
    {
        return Ok("This is the Quote of the HomeINSController");
    }

}