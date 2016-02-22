using MVCHelloWorldTeam1.DbModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCHelloWorldTeam1.Ef
{
    public class CategoryDao
    {

        //Declaration >>> Instatiation >>> Initialization
        private WarehouseContext context = new WarehouseContext();

        public void Save(Category category)
        {
            DbSet<Category> Categories = context.Categories;
            Categories.Add(category);
            context.SaveChanges();
        }


        public Category GetCategory(int categoryId)
        {
            Category category = context.Categories.Where(b => b.Id == categoryId).FirstOrDefault();
            return category;
        }

        public List<Category> GetCategories()
        {
            return context.Categories.ToList();
        }
    }
}