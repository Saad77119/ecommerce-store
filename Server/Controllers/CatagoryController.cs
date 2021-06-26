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
    public class CatagoryController : ControllerBase
    {
        CatagoryData objCatagory = new CatagoryData();
        [HttpGet]
        [Route("api/Catagories/Index")]
        public IEnumerable<Catagory> Index()
        {
            return objCatagory.GetAllCatagories();
        }

        [HttpPost]
        [Route("api/Catagories/Create")]
        public void Create([FromBody] Catagory Catagories)
        {
            if (ModelState.IsValid)
                objCatagory.AddCatagory(Catagories);
        }

        [HttpGet]
        [Route("api/Catagories/Details/{id}")]
        public Catagory Details(int id)
        {

            return objCatagory.GetCatagoryData(id);
        }

        [HttpPut]
        [Route("api/Catagories/Edit")]
        public void Edit([FromBody] Catagory Catagories)
        {
            if (ModelState.IsValid)
                objCatagory.UpdateCatagory(Catagories);
        }

        [HttpDelete]
        [Route("api/Catagories/Delete/{id}")]
        public void Delete(int id)
        {
            objCatagory.DeleteCatagory(id);
        }

    }
}


