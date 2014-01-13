using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ResturantApp.Models;
namespace ResturantApp.ViewModel
{
    public class CategoryData
    {

        public Category Category { set; get; }
        public IEnumerable<Item> Items { set; get; }

    }
}