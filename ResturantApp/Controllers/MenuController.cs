using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResturantApp.ViewModel;
using ResturantApp.Models;
using ResturantApp.DAL;
namespace ResturantApp.Controllers
{
    public class MenuController : Controller
    {
        //
        // GET: /Menu/

        private ResturantContext db = new ResturantContext();

        public ActionResult Index()
        {
            //Display All Categories
            //Display All the Items in each category

            var categories = db.Categories.ToList();
            var items = db.Items.ToList();
            string t = "";
            var Menu = new MenuData();
            Menu.CategoryDataItems = new Dictionary<Category, List<Item>>();
            Menu.Categories = categories;
            
            foreach(var cat in categories)
            {

                var its = from i in items where i.Category.Id == cat.Id select i;

                  Menu.CategoryDataItems.Add(cat,its.ToList());
            
            }




            return View(Menu);
        }

    }
}
