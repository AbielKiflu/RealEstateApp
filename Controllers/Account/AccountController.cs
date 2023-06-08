using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RealEstateApp.Models.User;

namespace RealEstateApp.Controllers;

public class AccountController : Controller
{

    private readonly UserManager<User> _userManager;
    private readonly SignInManager<User> _signInManager;

    public AccountController(UserManager<User> userManager,
                              SignInManager<User> signInManager)
    {
        _userManager = userManager;
        _signInManager = signInManager;
    }
 

    public String Index()
    {
        return "Hi there";
    }

    public ActionResult Login(){
        return View();
    }


     
    [HttpPost]
    [AllowAnonymous]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Register(User model)
    {
        if (ModelState.IsValid)
        {
            var user = new User
            {
                UserName = model.Email,
                Email = model.Email,
            };

            var result = await _userManager.CreateAsync(user, model.PasswordHash);

            if (result.Succeeded)
            {
                await _signInManager.SignInAsync(user, isPersistent: false);

                return RedirectToAction("index", "Home");
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }

            ModelState.AddModelError(string.Empty, "Invalid Login Attempt");

        }
        return View(model);
    }







    public IActionResult Register()
    {
        return View();
    }

     
 

 
}
