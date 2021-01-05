using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeskAssembleData
{
    public partial class Order
    {
        public string ItemName { get; set; }
        public string TeamName { get; set; }
        public string ContractName { get; set; }
        public string IsSaleName { get; set; }
        public string CountryName { get; set; }
        public int ItemPrice { get; set; }
        public int QuantityPrice
        {
            get
            {
                return Quantity * ItemPrice;
            }
        }

        public string YearQuarter
        {
            get
            {
                int month = Date.Month;
                int quarter = 0;
                if (month >= 1 && month <= 3)
                    quarter = 1;
                else if (month >= 4 && month <= 6)
                    quarter = 2;
                else if (month >= 7 && month <= 9)
                    quarter = 3;
                else
                    quarter = 4;

                // 2019.1Q
                return $"{Date.Year}.{quarter}Q";
            }
        }
    }
}
