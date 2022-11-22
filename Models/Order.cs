using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMart.Models
{
    public class Order
    {

        public int ID { get; set; }
        public int SupplierID { get; set; }
        public int ProductID { get; set; }
        public string Currency { get; set; }
        public datetime TransactionDate { get; set; }
        public int Quantity { get; set; }
        public float UnitPrice { get; set; }

    }
}
