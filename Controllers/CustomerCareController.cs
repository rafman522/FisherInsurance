using Microsoft.AspNetCore.Mvc;


[RouteAttribute("claim")]
public class CustomerCareController : Controller
{
    
    public IActionResult Index()
    {
        return Ok("This is the index of the CustomerCareController");
    }
    
    [RouteAttribute("fileclaim")]
    public IActionResult NewClaim()
    {
        return Ok("This is the New Claim/File Claim of the CustomerCareController");
    }
    [RouteAttribute("myclaims")]
    public IActionResult ClaimHistory()
    {
        return Ok("This is the claim History/My Claims of the CustomerCareController");
    }

}