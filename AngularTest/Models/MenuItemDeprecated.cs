﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularTest.Models
{
    public class MenuItemDeprecated
    {
        //I replaced this with the MenuItem Generated by entity framework
        public string ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }
        public string ImageURL { get; set; }
    }
}