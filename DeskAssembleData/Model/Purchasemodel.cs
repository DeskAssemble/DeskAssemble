using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeskAssembleData.Data
{
    public class Purchasemodel
    {
        public Purchasemodel(int id, int quantity)
        {
            ItemId = id;
            Quantity = quantity;

        }
        public int ItemId { get; set; }
        public int Quantity { get; set; }

    }
    public class Purchasemodel2
    {
        public int CategoryId { get; set; }

        //public string PartName { get; set; }

        public int Quantity { get; set; }

    }
    public class Purcahselistmodel
    {
        public int ItemId { get; set; }

        public string PartName { get; set; }

        public int Quantity { get; set; }
    }
}