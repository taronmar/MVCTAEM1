using MVCHelloWorldTeam1.DbModels;
using MVCHelloWorldTeam1.Ef;
using MVCHelloWorldTeam1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MVCHelloWorldTeam1.Controllers
{
    public class WarehouseController : Controller
    {

        private CategoryDao categoryDao = new CategoryDao();
        private ProductDao productDao = new ProductDao();


        // GET: Warehouse
        public ActionResult Index()
        { 
            //TODO fill dropdown values from DB into the model before loading page.
            return View(new WarehouseAddProductModel());
        }


        // POST: /Warehouse/AddProduct
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Index(WarehouseAddProductModel model, string returnUrl)
        {
            Product product = new Product();
            product.Name = model.Name;
            product.Price = (Decimal) model.Price;
            product.Quantity = (Decimal)model.Quantity;
            product.Code = (Int32)model.Code;

            //Category category = categoryDao.GetCategory((int)model.CategoryId);
            product.categoryId = (int) model.CategoryId;
            productDao.Save(product);
       

            return View(new WarehouseAddProductModel());
        }




    }
}