using Microsoft.AspNetCore.Mvc;



public class ClaimController : Controller
{
    [RouteAttribute("claim")]
    
    public IActionResult Index()
    {
        return Ok("This is the index of the ClaimController");
    }
    [RouteAttribute("claim/fileclaim")]
    public IActionResult NewClaim()
    {
        return Ok("This is the New Claim/File Claim of the ClaimController");
    }
    [RouteAttribute("claim/myclaims")]
    public IActionResult ClaimHistory()
    {
        return Ok("This is the claim History/My Claims of the ClaimController");
    }

}