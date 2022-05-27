using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaViewMVVMProject.Models
{
    class Pizza
    {
        public long Id { get; set; }
        public long PizzaPresetId { get; set; }        
        public int UnitPrice { get; set; }
        public bool includeTomato { get; set; }

        private List<long> excludedPresets;

    }
}
