using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaViewMVVMProject.Models
{
    public enum Discount { None, Low, Medium }

    public class Order
    {
        public long Id { get; set; }
        public long CustomerId { get; set; }
        public int TotalPrice { get; set; }
        public Discount Discount { get; set; }

        private List<long> orderItemIds;
    }
}
