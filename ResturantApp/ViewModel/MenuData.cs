using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ResturantApp.Models;
namespace ResturantApp.ViewModel
{
    public class MenuData
    {

        public Dictionary<Category,List<Item>> CategoryDataItems { set; get; }
        public List<Category> Categories { set; get; }

      

    }
}