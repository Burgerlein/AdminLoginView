using AdminPannelLogin.Backend.ViewModels;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace AdminPannelLogin.Backend.Controllers;
[Controller]
[Route("[controller]")]
public class HelloWorldController : ControllerBase
{
    [HttpGet("create")]
    public ActionResult get()
    {
        Auto auto = new Auto(){Name= "Mini", Kenzeichen = "KO TR 226"};
        return Ok(auto);
    }
}