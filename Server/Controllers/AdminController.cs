using Microsoft.AspNetCore.Http;
using Estore.Server.Models;
using Estore.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;


namespace Estore.Server.Controllers
{
    [Authorize]

    public class AdminController : ControllerBase
    {
        Userdata objUser = new Userdata();
      
        [HttpGet]
        [Route("api/admin/GetUserInfofromId")]
        public IEnumerable<AspNetUser> GetUserInfofromId()
        {
            return objUser.GetAllusers();

        }
    }
}


