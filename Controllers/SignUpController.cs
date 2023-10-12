using LoginProject.Models;
using LoginProject.Services;
using Microsoft.AspNetCore.Mvc;

namespace LoginProject.Controllers;

public class SignUpController : Controller{
    private readonly ISignUpService _spservice;
    public SignUpController(ISignUpService spservice)
    {
        _spservice = spservice;
    }

    [HttpGet]
    public IActionResult Index(){
        return View();
    }

    [HttpPost]
    public IActionResult Index(SignUpModel request){
        if(ModelState.IsValid)
            if(_spservice.AddingUserToDatabase(request))
                return RedirectToAction("Index", "Login");
        return Content("SignUp Failed!");
    }
}