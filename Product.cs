using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystem_Day3_2DArray
{
    public class Product
    {
        private int id;
        private string name;
        private int price;

        public Product(int id,string name,int price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }

        public override string ToString()
        {
            return id+" "+name+" "+price;
        }
    }
}
