using Estore.Server.Models;
using Estore.Shared.Models;
using Estore.Client.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Estore.Server.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
public class AuthController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly RoleManager<ApplicationUser> _roleManager;
        public AuthController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager )
        {
            _userManager = userManager;
            _signInManager = signInManager;


        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginRequest request)
        {

            // Sessionservices session = new Sessionservices();
            var user = await _userManager.FindByNameAsync(request.email);
            if (user == null) return BadRequest("User does not exist");
            var singInResult = await _signInManager.CheckPasswordSignInAsync(user, request.password, false);
            if (!singInResult.Succeeded) return BadRequest("Invalid password");
            await _signInManager.SignInAsync(user, request.Rememberme);


           
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterRequest parameters)
        {
            var user = new ApplicationUser();
            user.UserName = parameters.email;
            user.Email = parameters.email;

            
            var result = await _userManager.CreateAsync(user, parameters.password);
            if (!result.Succeeded) return BadRequest(result.Errors.FirstOrDefault()?.Description);
            IEnumerable<string> m_oEnum = new List<string>() { "Seller"};
            IEnumerable<string> m_buyer = new List<string>() { "Buyer" };
            if (parameters.Roleid == 2)
            {
                 await _userManager.AddToRolesAsync(user, m_oEnum);
            }
            else
            {
                await _userManager.AddToRolesAsync(user, m_buyer);
            }
            return await Login(new LoginRequest
            {
               email = parameters.email,
                password = parameters.password
            });
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return Ok();
        }

       


[HttpGet]
        public CurrentUser CurrentUserInfo()
        {

            return new CurrentUser
            {
                IsAuthenticated = User.Identity.IsAuthenticated,
                UserName = User.Identity.Name,
                Claims = User.Claims
                



                .ToDictionary(c => c.Type, c => c.Value)
            };
        }


      




    }
}
