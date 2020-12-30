using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DeskAssembleData.Data;
using DeskAssembleData.EFLibrary;
using System.Diagnostics;
using DeskAssembleData.Model;

namespace DeskAssembleData
{
    public class OrderDao : SingleKeyDao<Order, int>
    {

        protected override Expression<Func<Order, int>> KeySelector => throw new NotImplementedException();

        public List<Order> GetByPK(string orderId)
        {
            orderId.Trim();

            if (orderId == "")
                return null;

            int id = Convert.ToInt32(orderId);

            using (var context = DbContextCreator.Create())
            {
                var query = from x in context.Orders
                            where x.OrderId == id
                            select x;

                return query.ToList();
            }
        }

        public List<Order> GetByItemId(string itemId)
        {
            itemId.Trim();
            if (itemId == "")
                return null;
            int id = Convert.ToInt32(itemId);

            using (var context = DbContextCreator.Create())
            {
                var query = from x in context.Orders
                            where x.ItemId == id
                            select x;

                return query.ToList();
            }
        }

        //public List<Purchasemodel2> GetModels()
        //{
        //    {
        //        using (var context = DbContextCreator.Create())
        //        {
        //            var PartNames = context.Items.ToDictionary(x => x.ItemId, x => x.Name);

        //            var query = from i in context.Items
        //                        join o in context.Orders on i.ItemId equals o.ItemId
        //                        where o.IsSale == false && i.IsProduct == false
        //                        select new { Quantities = o.Orders.Sum(s => s.Quantity), ItemId = o.ItemId };

        //            var query2 = from x in query
        //                         group x by x.ItemId into g
        //                         select g;

        //            var Purchasemodels = new List<Purchasemodel2>();
        //            foreach (var group in query2)
        //            {
        //                Purchasemodel2 model = new Purchasemodel2();
        //                model.ItemId = group.Key;
        //                model.Quantity = group.Sum(g => g.Quantities);
        //                model.PartName = PartNames[group.Key];

        //                Purchasemodels.Add(model);
        //            }

        //            return Purchasemodels;
        //        }
        //    }

        //}

        public List<MapChartModel> GetPurchasedCountryModels()
        {
            {
                using (var context = DbContextCreator.Create())
                {
                    var countries = context.Countries.ToList();

                    List<MapChartModel> models = new List<MapChartModel>();
                    foreach (Country country in countries)
                    {
                        var query = from x in context.Orders
                                    where x.Contract.CountryId == country.CountryId && x.IsSale == false
                                    select x.Quantity;

                        var list = query.ToList();
                        MapChartModel model = new MapChartModel();
                        model.Value = list.Sum();
                        model.Latitude = country.Latitude;
                        model.Longitude = country.Longitude;

                        models.Add(model);
                    }

                    return models;
                }
            }

        }


    }

}