using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaViewMVVMProject.Models
{
    class OrderItem
    {
        public long Id { get; set; }
        public long PizzaId { get; set; }

        public int Quantity { get; set; }
        public int Price { get; set; }
        public bool Delivery { get; set; }
        public DateTime DeliveryTime { get; set; }
    }
}
