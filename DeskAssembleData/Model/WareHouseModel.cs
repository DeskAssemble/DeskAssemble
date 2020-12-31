﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeskAssembleData
{
    public class WareHouseModel
    {
        public WareHouseModel(/*int Wid,*/ int IId, int WQ)
        {
            //WareHouseId = Wid;
            ItemId = IId;
            WQuantity = WQ;
        }

        public int WareHouseId { get; set; }

        public int ItemId { get; set; }

        public string WareHouseName { get; set; }

        public int WQuantity { get; set; }

        public string ItemName { get; set; }
    }
}
