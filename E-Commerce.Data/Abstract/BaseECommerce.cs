using E_Commerce.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Data.Abstract
{
    public abstract class BaseECommerce
    {
        public int Id  { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }

        public  DateTime? DeletedDate { get; set; }

        public Status Status { get; set; } = Status.Added;
    }
}
