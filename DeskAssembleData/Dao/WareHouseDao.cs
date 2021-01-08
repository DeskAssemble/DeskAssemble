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
    }
}
