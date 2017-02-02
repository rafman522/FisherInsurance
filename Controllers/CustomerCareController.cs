using Microsoft.AspNetCore.Mvc;

[Route("customer")]
public class CustomerCareController : Controller
{
    
    public IActionResult Index()
    {
        return Ok("This is the index of the CustomerCareController");
    }
    public IActionResult Claims()
    {
        return Ok("This is the Quote of the CustomerCareController");
    }

}