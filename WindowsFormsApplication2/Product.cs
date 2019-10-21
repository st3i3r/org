using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class Product
    {
        public event EventHandler<EventArgs> OutOfStock;

        public int code { get; set; }
        public string product { get; set; }
        public int quantity { get; set; }
    }

    class ProductEventArgs : EventArgs
    {

    }
}
