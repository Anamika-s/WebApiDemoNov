﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiClient.Models
{
    public class Item
    {

        public int id { get; set; }
        public string name { get; set; }
        public int qtyStock { get; set; }
        public string description { get; set; }
    }

}