using MVCHelloWorldTeam1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MVCHelloWorldTeam1.Controllers
{
    public class WarehouseController : Controller
    {
        // GET: Warehouse
        public ActionResult Index()
        {

            return View(new WarehouseAddProductModel());
        }

        
        // POST: /Warehouse/AddProduct
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AddProduct(WarehouseAddProductModel model, string returnUrl)
        {
            //TODO Saveinto the database
            //TODO Refresh the page
            RedirectToAction("Index", "Warehouse");

            return View();
        }
    }
}