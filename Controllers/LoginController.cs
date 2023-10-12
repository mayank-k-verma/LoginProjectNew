using LoginProject.Models;
using LoginProject.Services;
using Microsoft.AspNetCore.Mvc;

namespace LoginProject.Controllers;

public class LoginController : Controller{
    private readonly ILoginService _lgservice;
    public LoginController(ILoginService lgservice)
    {
        _lgservice = lgservice;
    }

    [HttpGet]
    public IActionResult Index(){
        return View();
    }

    [HttpPost]
    public IActionResult Index(LoginModel request){
        if(ModelState.IsValid)
            if(_lgservice.CheckingUserFromDatabase(request))
                return Content("Logged In...");
        return Content("Login Failed!");
    }
}