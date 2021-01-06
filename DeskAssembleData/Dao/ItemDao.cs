﻿using System;
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

        public List<Item> GetItemsByCategoryId(int categoryId)
        {
            using (var context = DbContextCreator.Create())
            {
                var query = from x in context.Items
                            where x.CategoryId == categoryId
                            //orderby x.CategoryId
                            select x;

                var items = query.ToList();

                foreach (Item item in items)
                {
                    item.QuantitySum = GetQuantitySum(item.ItemId);
                }

                return items;
            }
        }

        int GetQuantitySum(int itemId)
        {
            using (var context = DbContextCreator.Create())
            {
                var query = from x in context.Orders
                            where x.ItemId == itemId
                            select x.Quantity;

                return query.ToList().Sum();
            }

        }

        public List<PurcahsePlatemodel> GetPurchasePlateModels()
        {
            {
                using (var context = DbContextCreator.Create())
                {

                    var items = context.Items.ToList();

                    List<PurcahsePlatemodel> models = new List<PurcahsePlatemodel>();

                    foreach (Item item in items)
                    {
                        var query = from o in context.Orders
                                    where o.ItemId == item.ItemId && o.IsSale == false && o.Item.IsProduct == false
                                    select o.Quantity;

                        var list = query.ToList();

                        PurcahsePlatemodel model = new PurcahsePlatemodel();

                        model.Quantity = list.Sum();
                        model.ItemId = item.ItemId;
                        model.PartName = item.Name;


                        models.Add(model);
                    }
                    return models;
                }
               
            }

        }
        public List<ProductsaledetailModel> GetProductsaledetailModels()
        {
            using (var context = DbContextCreator.Create())
            {

                var contracts = context.Contracts.ToList();

                List<ProductsaledetailModel> smodels = new List<ProductsaledetailModel>();

                foreach (Contract contract in contracts)
                {
                    var query = from o in context.Orders
                                where o.ContractId == contract.ContractId && o.IsSale == true && o.Item.IsProduct == true
                                 && o.Contract.IsVendee == true && o.ItemId == o.Item.ItemId
                                select o.Quantity;

                    var list = query.ToList();

                    ProductsaledetailModel smodel = new ProductsaledetailModel();

                    smodel.Quantity = list.Sum();
                    smodel.ContractId = contract.ContractId;
                    smodel.VendeeName = contract.Name;


                    smodels.Add(smodel);
                }
                return smodels;
            }

        }


    }
}
