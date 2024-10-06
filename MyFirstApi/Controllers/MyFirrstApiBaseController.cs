using Microsoft.AspNetCore.Mvc;
namespace MyFirstApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public abstract class MyFirrstApiBaseController : ControllerBase
{
    public string Author { get; set; } = "Jhon R";
    [HttpGet("Heathy")]
    public IActionResult Heathy()
    {
        return Ok("It's working");
    }
    protected string GetCustomKey()
    {
        return Request.Headers["MyKey"].ToString();
    }
}
