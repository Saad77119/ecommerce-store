using Microsoft.AspNetCore.Mvc;

using Estore.Server.Data;
using Estore.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estore.Server.Models
{
    public class ProductData
    {
        DataContext db = new DataContext();
        public IEnumerable<Product> GetAllProducts()
        {
            try
            {
                return db.Products.ToList();
            }
            catch
            {
                throw;
            }
        }

        //To Add new Product record     
        public void AddProduct(Product Product)
        {
            try
            {

                db.Products.Add(Product);
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public void AddProductCatagory(ProductCatagory ProductCatagory)
        {
            try
            {

                db.ProductCatagorys.Add(ProductCatagory);
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        //To Update the records of a particluar Product    
        public void UpdateProduct(Product Product)
        {
            try
            {
                db.Entry(Product).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        //Get the details of a particular Product    
        public Product GetProductData(int id)
        {
            try
            {
                Product Product = db.Products.Find(id);
                return Product;
            }
            catch
            {
                throw;
            }
        }

        //To Delete the record of a particular Product   
        public void DeleteProduct(int id)
        {
            try
            {
                Product Product = db.Products.Find(id);
                db.Products.Remove(Product);
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
