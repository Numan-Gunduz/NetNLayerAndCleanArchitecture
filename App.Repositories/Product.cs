﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Repositories
{
    public class Product
    {
        public int? Id { get; set; }
        public string?  Name { get; set; }
        public decimal  Price { get; set; }
        public int Stoct { get; set; }
    }
}
