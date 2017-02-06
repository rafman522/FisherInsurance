using Microsoft.AspNetCore.Mvc;



public class CustomerCareController : Controller
{
    [RouteAttribute("customer")]
    [RouteAttribute("customer/index")]
    
    public IActionResult Index()
    {
        return Ok("This is the index of the CustomerCareController");
    }
    [RouteAttribute("customer/claims")]
    public IActionResult Claims()
    {
        return Ok("This is the claims of the CustomerCareController");
    }

}