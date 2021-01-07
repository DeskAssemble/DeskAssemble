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

        public List<Purcahselistmodel> GetItemsByCategoryId(int categoryId)
        {
            using (var context = DbContextCreator.Create())
            {
                List<Purcahselistmodel> models = new List<Purcahselistmodel>();

                var query = from x in context.Items
                            where x.CategoryId == categoryId
                            select x;

                var items = query.ToList();

                foreach (Item item in items)
                {
                    Purcahselistmodel model = new Purcahselistmodel();

                    item.QuantitySum = GetQuantitySum(item.ItemId);

                    model.Quantity = item.QuantitySum;
                    model.ItemId = item.ItemId;
                    model.PartName = item.Name;

                    models.Add(model);
                }

                return models;
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

        public List<ProductsaledetailModel> GetContractorByItemId(int ItemId)
        {
            using (var context = DbContextCreator.Create())
            {
                List<ProductsaledetailModel> smodels = new List<ProductsaledetailModel>();



                var query = from x in context.Orders
                            where x.ItemId == ItemId && x.IsSale == true && x.Contract.IsVendee == true
                            select x;

                var items = query.ToList();

                foreach (Order item in items)
                {
                    ProductsaledetailModel smodel = new ProductsaledetailModel();

                    item.SaleQuantitySum = GetSaleQuantitySum(item.ItemId);



                    smodel.Quantity = item.SaleQuantitySum;
                    smodel.ContractId = item.ContractId;
                    //smodel.VendeeName = item.Contract.Name;


                    smodels.Add(smodel);
                }
                return smodels;
            }


        }
        int GetSaleQuantitySum(int contractId)
        {
            using (var context = DbContextCreator.Create())
            {
                var query = from x in context.Orders
                            where x.ContractId == contractId
                            select x.Quantity;

                return query.ToList().Sum();
            }

        }



        //public List<ProductsaledetailModel> GetProductsaledetailModels()
        //{
        //    using (var context = DbContextCreator.Create())
        //    {

        //        var contracts = context.Contracts.ToList();

        //        List<ProductsaledetailModel> smodels = new List<ProductsaledetailModel>();

        //        foreach (Contract contract in contracts)
        //        {
        //            var query = from o in context.Orders
        //                        where o.ContractId == contract.ContractId && o.IsSale == true && o.Item.IsProduct == true
        //                         && o.Contract.IsVendee == true && o.ItemId == o.Item.ItemId
        //                        select o.Quantity;

        //            var list = query.ToList();

        //            ProductsaledetailModel smodel = new ProductsaledetailModel();

        //            smodel.Quantity = list.Sum();
        //            smodel.ContractId = contract.ContractId;
        //            smodel.VendeeName = contract.Name;


        //            smodels.Add(smodel);
        //        }
        //        return smodels;
        //    }

        //}


    }
}
