using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeskAssembleData.Data
{
    class Salemodel
    {
        public Salemodel(int id, int quantity)
        {
            ItemId = id;
            Quantity = quantity;

        }
        public int ItemId { get; set; }
        public int Quantity { get; set; }
    }

    public class Salemodel2
    {
        public int ItemId { get; set; }

        public string ProductName { get; set; }

        public int Quantity { get; set; }

    }

    public class ProductsaledetailModel
    {
        public int ContractId { get; set; }

        public string VendeeName { get; set; }

        public int Quantity { get; set; }
        
    }
}