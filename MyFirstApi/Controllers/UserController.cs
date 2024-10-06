using Microsoft.AspNetCore.Mvc;
using MyFirstApi.Comunication.Requests;
using MyFirstApi.Comunication.Responses;
namespace MyFirstApi.Controllers;
public class UserController : MyFirrstApiBaseController
{
    [HttpGet]
    [Route("{Id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult GetByIdAndNickname([FromRoute] int Id)
    {
        var user = new User 
        {
            Id = 1,
            Age = 20,
            Name = "Test"
        };
        return Ok(user);
    }
    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisteredUserJson), StatusCodes.Status201Created)]
    public IActionResult CreateUser([FromBody] RequestRegisterUserJson request)
    {
        var response = new ResponseRegisteredUserJson
        {
            Id = 1,
            Name = request.Name
        };
        return Created(string.Empty, response);
    }
    [HttpPut]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Update([FromBody] RequestUpdateUserProfileJson request)
    {
        return NoContent();
    }
    [HttpDelete]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Delete()
    {
        return NoContent();
    }
    [HttpGet]
    [ProducesResponseType(typeof(List<User>), StatusCodes.Status200OK)]
    public IActionResult GetAll()
    {
        var response = new List<User>()
        {
            new User{Id = 2, Age = 2 , Name = "Test"},
            new User{Id = 3, Age = 3 , Name = "Test2"}
        };
        var key = GetCustomKey();
        return Ok(key);
    }
    [HttpPut("ChangePassword")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult ChangePassword([FromBody] RequestChangePasswordJson request)
    {
        return NoContent();
    }
}
