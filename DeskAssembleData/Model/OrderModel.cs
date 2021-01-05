using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeskAssembleData
{
    public class OrderModel
    {
        public OrderModel(int month, int quantity)
        {
            Month = month;
            Quantity = quantity;
        }

        public int ItemId { get; set; }
        public int Quantity { get; set; }
        public int Month { get; set; }
    }
}
