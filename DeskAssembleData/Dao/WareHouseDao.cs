using DeskAssembleData.EFLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DeskAssembleData.Dao
{
    public class WareHouseDao : SingleKeyDao<WareHouse, int>
    {
        protected override Expression<Func<WareHouse, int>> KeySelector => throw new NotImplementedException();

        public List<WareHouseModel> GetQuantity()
        {
            using (DeskAssemblyEntities context = DbContextCreator.Create())
            {
                Dictionary<int, string> itemNames = context.Items.ToDictionary(x => x.ItemId, x => x.Name);
                Dictionary<int, string> warehouseNames = context.WareHouses.ToDictionary(x => x.WarehouseId, x => x.Name);

                var query = from x in context.Movements
                            group x by x.ItemId into g
                            select g;

                List < WareHouseModel > models = new List<WareHouseModel>();

                foreach (var @group in query)
                {
                    WareHouseModel model = new WareHouseModel(group.Key, group.Sum(x => x.Quantity));
                    model.ItemName = itemNames[model.ItemId];
                    model.WareHouseName = warehouseNames[model.WareHouseId];
                    models.Add(model);
                }
                return models;
            }
        }
    }
}
