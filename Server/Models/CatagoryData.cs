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
    public class CatagoryData
    {
        DataContext db = new DataContext();
        public IEnumerable<Catagory> GetAllCatagories()
        {
            try
            {
                return   db.Catagorys.ToList();
            }
            catch
            {
                throw;
            }
        }

        //To Add new Catagory record     
        public void AddCatagory(Catagory Catagory)
        {
            try
            {
                db.Catagorys.Add(Catagory);
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        //To Update the records of a particluar Catagory    
        public void UpdateCatagory(Catagory Catagory)
        {
            try
            {
                db.Entry(Catagory).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        //Get the details of a particular Catagory    
        public Catagory GetCatagoryData(int id)
        {
            try
            {
                Catagory Catagory = db.Catagorys.Find(id);
                return Catagory;
            }
            catch
            {
                throw;
            }
        }

        //To Delete the record of a particular Catagory    
        public void DeleteCatagory(int id)
        {
            try
            {
                Catagory Catagory = db.Catagorys.Find(id);
                db.Catagorys.Remove(Catagory);
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}


