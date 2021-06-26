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
   
    public class ShopData 
    {
        DataContext db = new DataContext();
        public IEnumerable<Shop> GetAllShops()
        {
            try
            {
                return db.Shops.ToList();
            }
            catch
            {
                throw;
            }
        }

        //To Add new Shop record     
        public void AddShop(Shop Shop)
        {
            try
            {
                db.Shops.Add(Shop);
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        //To Update the records of a particluar Shop    
        public void UpdateShop(Shop Shop)
        {
            try
            {
                db.Entry(Shop).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        //Get the details of a particular Shop    
        public Shop GetShopData(int id)
        {
            try
            {
                Shop Shop = db.Shops.Find(id);
                return Shop;
            }
            catch
            {
                throw;
            }
        }

        //To Delete the record of a particular Shop    
        public void DeleteShop(int id)
        {
            try
            {
                Shop Shop = db.Shops.Find(id);
                db.Shops.Remove(Shop);
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
