﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        //urun fiyatı
        public double UnıtPrice { get; set; }
        //urun stok adedi
        public int UnıtsInStock { get; set; }
    }
}
