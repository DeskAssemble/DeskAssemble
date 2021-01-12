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
                    var partNames = context.Items.ToDictionary(x => x.ItemId, x => x.Name);

                    var query = from p in context.Orders
                                where p.IsSale == false
                                select new
                                {
                                    Order = p,
                                    Quantity = p.Quantity,
                                    CategoryId = p.Item.CategoryId
                                };

                    var query2 = from x in query
                                 group x by x.CategoryId into g
                                 select g;

                    var models = new List<Purchasemodel2>();

                    foreach (var @group in query2)
                    {
                        Purchasemodel2 model = new Purchasemodel2();
                        model.CategoryId = group.Key;
                        model.Quantity = group.Sum(x => x.Quantity);

                        if (model.CategoryId == 2)
                            model.CategoryName = "판";
                        else if (model.CategoryId == 3)
                            model.CategoryName = "다리";
                        else if (model.CategoryId == 4)
                            model.CategoryName = "볼트 & 너트";

                        models.Add(model);
                    }
                    return models;            
                }
               
            }
            
        }

        public List<Salemodel2> GetSaleModels()
        {
            {
                using (var context = DbContextCreator.Create())
                {
                    var productNames = context.Items.ToDictionary(x => x.ItemId, x => x.Name);

                    var query = from p in context.Orders
                                where p.IsSale == true
                                select new
                                {
                                    Order = p,
                                    Quantity = p.Quantity,
                                    ProductName = p.Item.Name,
                                    ItemId = p.ItemId
                                };

                    var query2 = from x in query
                                 group x by x.ItemId into g
                                 select g;

                    var models = new List<Salemodel2>();

                    foreach (var @group in query2)
                    {
                        Salemodel2 model = new Salemodel2();
                        model.ItemId = group.Key;
                        model.Quantity = group.Sum(g => g.Quantity);
                        model.ProductName = productNames[group.Key];
                        models.Add(model);
                    }
                    return models;
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

        public List<Order> Search()
        {
            using (DeskAssemblyEntities context = DbContextCreator.Create())
            {
                var query = from x in context.Orders
                            select new
                            {
                                Order = x,
                                ItemName = x.Item.Name,
                                TeamName = x.Team.Name,
                                ContractName = x.Contract.Name,
                                IsSaleName = x.IsSale
                            };

                var list = query.ToList();
                foreach (var item in list)
                {
                    item.Order.ItemName = item.ItemName;
                    item.Order.TeamName = item.TeamName;
                    item.Order.ContractName = item.ContractName;
                    if (item.Order.IsSale == true)
                        item.Order.IsSaleName = "판매";
                    else
                        item.Order.IsSaleName = "구매";
                }
                return list.Select(x => x.Order).ToList();
            }
        }

        public List<Order> Pivot()
        {
            using (DeskAssemblyEntities context = DbContextCreator.Create())
            {
                var query = from x in context.Orders
                            select new
                            {
                                Order = x,
                                ItemName = x.Item.Name,
                                ContractName = x.Contract.Name,
                                CountryName = x.Contract.Country.Name,
                                ItemPrice = x.Item.Price
                            };

                var list = query.ToList();

                List<Order> orders = new List<Order>();

                foreach(var x in list)
                {
                    x.Order.ItemName = x.ItemName;
                    x.Order.ContractName = x.ContractName;
                    x.Order.CountryName = x.CountryName;
                    x.Order.ItemPrice = x.ItemPrice;

                    orders.Add(x.Order);
                }

                return orders;
            }
        }

        public List<OrderModel> OrderModels()
        {
            using (DeskAssemblyEntities context = DbContextCreator.Create())
            {
                var query = from p in context.Orders
                            where p.IsSale == true
                            select new
                            {
                                Order = p,
                                Price = p.Item.Price,
                                Quantity = p.Quantity,
                                Month = p.Date.Month,
                                QuantityPrice = p.Quantity * p.Item.Price,
                            };

                var query2 = from x in query
                             group x by x.Month into g
                             select g;

                List<OrderModel> models = new List<OrderModel>();

                foreach (var @group in query2)
                {
                    OrderModel model = new OrderModel();
                    model.Month = group.Key;
                    model.QuantityPrice = group.Sum(g => g.QuantityPrice);
                    if (model.Month != 1)
                    {
                        model.ProfitRate = (((model.QuantityPrice - models[models.Count-1].QuantityPrice) * 1.0) / models[models.Count-1].QuantityPrice) * 100;
                    }
                    models.Add(model);
                }

                return models;
            }
        }
    }
}