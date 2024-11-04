
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.ApplicationCore.Entities
{
    public class Order_Detail
    {
        public int Id { get; set; }
        public int Order_id { get; set; }
        public int Product_id { get; set; }
        public string Product_name { get; set; }
        public int Qty { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
    }
}
