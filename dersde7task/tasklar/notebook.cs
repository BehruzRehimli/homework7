using System;
using System.Collections.Generic;
using System.Text;

namespace tasklar
{
    internal class notebook
    {
        public string Brand;
        public string Model;
        public double Price;
        public void ShowInfo()
        {
            Console.WriteLine($"Bu komputerin brendi: {Brand} ,modeli: {Model} ,qiymeti ise {Price} azn-dir"); 
        } 
        public notebook(string brand,string model,double price=0)
        {
            Brand= brand ;
            Model= model ;
            Price= price ;
        }

    }
}
