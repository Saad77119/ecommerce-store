using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;

namespace Estore.Server.Controllers
{
    [Authorize]
    public class ProductController : ControllerBase
    {
        private readonly IWebHostEnvironment environment;
        public ProductController(IWebHostEnvironment environment)
        {
            this.environment = environment;
        }

        ProductData objProduct = new ProductData();
        [HttpGet]
        [Route("api/Products/Index")]
        public IEnumerable<Product> Index()
        {
            return objProduct.GetAllProducts();
        }

        [HttpPost]
        [Route("api/Products/Create")]
        public void Create([FromBody] Product Products)
        {
            if (ModelState.IsValid)
                objProduct.AddProduct(Products);


            string[] CatagoryList = Products.CatagoryID.Split(",");
            foreach (string SingleCatagory in CatagoryList)
            {
                ProductCatagory ProductCatagory = new ProductCatagory();
                ProductCatagory.ProductID = Products.ID;
                ProductCatagory.CatagoryID = Convert.ToInt32(SingleCatagory);
                objProduct.AddProductCatagory(ProductCatagory);
            }
        }

        [HttpGet]
        [Route("api/Products/Details/{id}")]
        public Product Details(int id)
        {

            return objProduct.GetProductData(id);
        }

        [HttpPut]
        [Route("api/Products/Edit")]
        public void Edit([FromBody] Product Products)
        {
            if (ModelState.IsValid)
                objProduct.UpdateProduct(Products);
        }

        [HttpDelete]
        [Route("api/Product/Delete/{id}")]
        public void Delete(int id)
        {
            objProduct.DeleteProduct(id);
        }

        [HttpPost]
        [Route("api/Products/imagesave")]
        public async Task<string> Imagesave()
        {
            string path = "";
            if (HttpContext.Request.Form.Files.Any())
            {
                foreach (var file in HttpContext.Request.Form.Files)
                {
                    path = Path.Combine(environment.ContentRootPath, "Images", file.FileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                }

            }
            byte[] ByteArray = System.IO.File.ReadAllBytes(path);

            return Convert.ToBase64String(ByteArray);
        }
    }
}




