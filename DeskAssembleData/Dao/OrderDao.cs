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

        public List<Purchasemodel2> GetPurchasemodelModels()
        {
            {
                using (var context = DbContextCreator.Create())
                {
                    var PartNames = context.Items.ToDictionary(x => x.ItemId, x => x.Name);
                    var items = context.Items.ToList();

                    List<Purchasemodel2> pmodels = new List<Purchasemodel2>();
                    foreach (Item item in items)
                    {
                        var query = from o in context.Orders
                                    where o.ItemId == item.ItemId && o.IsSale == false
                                    select o.Quantity;

                        var list = query.ToList();
                        Purchasemodel2 pmodel = new Purchasemodel2();
                        pmodel.Quantity = list.Sum();
                        pmodel.ItemId = item.ItemId;
                        pmodel.PartName = item.Name;

                        pmodels.Add(pmodel);
                    }

                    return pmodels;
                }
            }
        }

        public List<Salemodel2> GetSaleModels()
            {
                {
                    using (var context = DbContextCreator.Create())
                    {
                        var ProductNames = context.Items.ToDictionary(x => x.ItemId, x => x.Name);

                        var query = from i in context.Items
                                    join o in context.Orders on i.ItemId equals o.ItemId
                                    where o.IsSale == true && i.IsProduct == true
                                    select new { Quantities = i.Orders.Sum(s => s.Quantity), ItemId = o.ItemId };

                        var query2 = from x in query
                                     group x by x.ItemId into g
                                     select g;

                        var Salemodels = new List<Salemodel2>();
                        foreach (var group in query2)
                        {
                            Salemodel2 smodel = new Salemodel2();
                            smodel.ItemId = group.Key;
                            smodel.Quantity = group.Sum(g => g.Quantities);
                            smodel.ProductName = ProductNames[group.Key];

                            Salemodels.Add(smodel);
                        }

                        return Salemodels;
                    }
                }
        }

        //국가별 부품 구매량 모델
        public List<MapChartModel> GetPurchasedCountryModels()
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
                    model.Name = country.Name;
                    model.CountryId = country.CountryId;

                    models.Add(model);
                }

                    return models;
            }

        }

        //국가별 부품 구매량 상세 모델
        //public List<MapChartDetailModel> GetPurchasedCountryDetailModels(int countryId)
        //{
        //    using (var context = DbContextCreator.Create())
        //    {
        //        var Orders = context.Orders.ToList();

        //        var query = from x in context.Orders
        //                    where x.Contract.CountryId == countryId && x.IsSale == false
        //                    select new { Quantity = x.Quantity, ContractName = x.Contract.Name, ItemName = x.Item };
        //    }
                       
        //}

        //국가별 제품 판매량 모델
        public List<MapChartModel> GetSoldCountryModels()
        {
            using (var context = DbContextCreator.Create())
            {
                var countries = context.Countries.ToList();
            
                List<MapChartModel> models = new List<MapChartModel>();

                foreach (Country country in countries)
                {
                    var query = from x in context.Orders
                                where x.Contract.CountryId == country.CountryId && x.IsSale == true
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