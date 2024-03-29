﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class Product
    {
        public event EventHandler<ProductEventArgs> OutOfStock;

        public int code { get; set; }
        public string product { get; set; }
        public int quantity { get; set; }
        public bool flag_OutOfStock { get; set; }

        public void CheckQuantity()
        {
            if (this.quantity == 0)
            {
                this.flag_OutOfStock = true;
                OutOfStock(this, new ProductEventArgs(this.product));
            }
        }
    }


    class ProductEventArgs : EventArgs
    {
        public String Product { get; set; }

        public ProductEventArgs(String _product)
        {
            Product = _product;
        }
    }
}
