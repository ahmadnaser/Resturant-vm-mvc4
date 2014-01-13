using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Security;

namespace ResturantApp.Models
{
    public class Item
    {
        public int Id { set; get; }
        public string Name { set; get; }

        public string Description { set; get; }
     
        [Display(Name="Unit Price")]
        public int Price { set; get; }

      
        public int CategoryId { set; get; }

        public virtual Category Category { set; get; }


    }
}