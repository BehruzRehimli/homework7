using System;
using System.Collections.Generic;
using System.Text;

namespace tasklar
{
    internal class Product
    {
        public Product(string name,int price,byte dis=0) {
            Name = name;
            Price = price;
            DiscountPercent = dis;
        }
        public string Name;
        public int Price;
        public byte DiscountPercent;

    }
}
