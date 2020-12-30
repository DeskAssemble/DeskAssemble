using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DeskAssembleData.Data;
using DeskAssembleData.EFLibrary;

namespace DeskAssembleData
{
    public class ItemDao : SingleKeyDao<Item, int>
    {
        protected override Expression<Func<Item, int>> KeySelector => throw new NotImplementedException();
        //public List<Salemodel2> GetModels()
        //{
        //    {
        //        using (var context = DbContextCreator.Create())
        //        {
        //            var ProductNames = context.Items.ToDictionary(x => x.ItemId, x => x.Name);

        //            var query = from i in context.Items
        //                        join o in context.Orders on i.ItemId equals o.ItemId
        //                        where o.IsSale == true && i.IsProduct == true
        //                        select new { Quantities = i.Orders.Sum(s => s.Quantity), ItemId = o.ItemId };

        //            var query2 = from x in query
        //                         group x by x.ItemId into g
        //                         select g;

        //            var Salemodels = new List<Salemodel2>();
        //            foreach (var group in query2)
        //            {
        //                Salemodel2 smodel = new Salemodel2();
        //                smodel.ItemId = group.Key;
        //                smodel.Quantity = group.Sum(g => g.Quantities);
        //                smodel.ProductName = ProductNames[group.Key];

        //                Salemodels.Add(smodel);
        //            }

        //            return Salemodels;
        //        }
        //    }


        //}
    }
}
