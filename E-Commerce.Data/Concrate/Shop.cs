using E_Commerce.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Data.Concrate
{
    public class Shop:BaseECommerce,IEntity
    {

        public string Name { get; set; }
        public string lat { get; set; }
        public string lng { get; set; }
        public string Address { get; set; }
        public string Gsm { get; set; }
        public string Email { get; set; }
    }
}
