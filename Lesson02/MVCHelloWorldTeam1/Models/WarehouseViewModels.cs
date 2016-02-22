using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCHelloWorldTeam1.Models
{
    public class WarehouseAddProductModel
    {

        public class Category
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        public IEnumerable<SelectListItem> Categories
        {
           get{ return new SelectList(_categoryList, "Id", "Name"); }
        }

        public IEnumerable<Category> _categoryList =
            new List<Category>
            {
                new Category {Id = 0, Name = "Drink"},
                new Category {Id = 1, Name = "Chocolate"}
            };

        [Required]
        //[Display(Name = "Name")]
        public String Name { get; set; }

        [Required]
        public Int32? CategoryId { get; set; }

        [Required]
        public Decimal? Price { get; set; }

        [Required]
        public Decimal? Quantity { get; set; }

        [Required]
        public Int32? Code { get; set; }
    }
}