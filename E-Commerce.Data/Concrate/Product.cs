using E_Commerce.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Data.Concrate
{
    public class Product:BaseECommerce,IEntity
    {
        public string  Name { get; set; }

        public string  Description { get; set; }

        public int Stock { get; set; }

        public Shop Shop  { get; set; }

        public Size  Size { get; set; }


    }

}
