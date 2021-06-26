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
    public class ShopsController : ControllerBase
    {
        ShopData objCatagory = new ShopData();
    
        private readonly UserManager<ApplicationUser> _userManager;
        public ShopsController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
         
        }

        [HttpGet]
        [Route("api/Shops/Index")]
        public IEnumerable<Shop> Index()
        {
            return objCatagory.GetAllShops();
        }

        [HttpPost]
        [Route("api/Shops/Create")]
        public void Create([FromBody] Shop Shops)
        {
            if (ModelState.IsValid)
                objCatagory.AddShop(Shops);
        }

        [HttpGet]
        [Route("api/Shops/Details/{id}")]
        public Shop Details(int id)
        {

            return objCatagory.GetShopData(id);
        }

        [HttpPut]
        [Route("api/Shops/Edit")]
        public void Edit([FromBody] Shop Shops)
        {
            if (ModelState.IsValid)
                objCatagory.UpdateShop(Shops);
        }

        [HttpDelete]
        [Route("api/Shops/Delete/{id}")]
        public void Delete(int id)
        {
            objCatagory.DeleteShop(id);
        }

    }
}
