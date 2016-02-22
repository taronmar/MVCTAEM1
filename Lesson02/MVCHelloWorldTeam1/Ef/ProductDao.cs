using MVCHelloWorldTeam1.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCHelloWorldTeam1.Ef
{

    public class ProductDao
    {
        private WarehouseContext context = new WarehouseContext();
        
        public void Save(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
        } 
    }
}