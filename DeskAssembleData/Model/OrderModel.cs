using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeskAssembleData
{
    public class OrderModel
    {
        public int Price { get; set; }
        public int ItemId { get; set; }
        public int Quantity { get; set; }
        public int Month { get; set; }
        public int QuantityPrice { get; set; }
        public double ProfitRate { get; set; }
    }
}
