using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMart.Models
{
    public class Sale
    {

        public int ID { get; set; }
        public string Currency { get; set; }
        public datetime TransactionDate { get; set; }
        public float GrandTotal { get; set; }
    
    }
}
