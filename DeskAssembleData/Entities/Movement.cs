using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeskAssembleData
{
    public partial class Movement
    {
        public string ItemName { get; set; }
        public string ContractName { get; set; }
        public string WareHouseName { get; set; }
        public string IsInName { get; set; }
        public bool IsProduct { get; set; }
        public string IsProductName { get; set; }
        public int TotalQuantity { get; set; }
        //{
        //    get
        //    {
        //        return 0;
        //    }
        //    set { }
        //}
    }
}
