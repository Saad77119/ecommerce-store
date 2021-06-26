using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estore.Shared.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string UserID { get; set; }
        public string CatagoryID { get; set; }
        public int ShopID { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
       
    }
}
