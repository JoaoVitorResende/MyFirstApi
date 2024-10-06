using Microsoft.AspNetCore.Mvc;
using MyFirstApi.Entities;
namespace MyFirstApi.Controllers;
public class DeviceController : MyFirrstApiBaseController
{
    [HttpGet]
    public IActionResult Get()
    {
        var key = GetCustomKey();
        Laptop laptop = new Laptop();
        var model = laptop.GetModel();
        return Ok(key);
    }
}
