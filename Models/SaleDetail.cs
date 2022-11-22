using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMart.Models
{
    public class SaleOrder
    {

        public int ProductID { get; set; }
        public int SaleID { get; set; }
        public string Currency { get; set; }
        public int Quantity { get; set; }
        public float UnitPrice { get; set; }
        public float TotalAmount { get; set; }

    }
}
