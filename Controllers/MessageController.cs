using Microsoft.AspNetCore.Mvc;

[Route("api/message")]
[ApiController]
public class MessageController : ControllerBase
{
    [HttpGet]
    public ActionResult<string> Get()
    {
        return "Yes, it's connected!";
    }
}