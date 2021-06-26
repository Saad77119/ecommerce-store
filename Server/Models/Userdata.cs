using Estore.Server.Data;
using System;
using Estore.Shared.Models;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;

namespace Estore.Server.Models
{
    public class Userdata
    {
        DataContext db = new DataContext();
        public IEnumerable<AspNetUser> GetAllusers()
        {
            try
            {

                return db.AspNetUsers.ToList();
            }
            catch
            {
                throw ;
            }
        }
    }
}
