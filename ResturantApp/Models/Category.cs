﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ResturantApp.Models
{
    public class Category
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }

    }
}