using DeskAssembleData.EFLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DeskAssembleData.Dao
{
    public class MovementDao : SingleKeyDao<Movement, int>
    {
        protected override Expression<Func<Movement, int>> KeySelector => throw new NotImplementedException();

        public List<Movement> Search()
        {
            using (DeskAssemblyEntities context = DbContextCreator.Create())
            {
                var query = from x in context.Movements
                            select new
                            {
                                Movement = x,
                                ItemName = x.Item.Name,
                                ContractName = x.Contract.Name,
                                WareHouseName = x.WareHouse.Name,
                                IsInName = x.IsIn
                            };

                var list = query.ToList();
                foreach(var item in list)
                {
                    item.Movement.ItemName = item.ItemName;
                    item.Movement.ContractName = item.ContractName;
                    item.Movement.WareHouseName = item.WareHouseName;
                    if (item.Movement.IsIn == true)
                        item.Movement.IsInName = "입고";
                    else
                        item.Movement.IsInName = "출고";
                }
                return list.Select(x => x.Movement).ToList();

            }
        }
    }
}
