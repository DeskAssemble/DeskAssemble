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
    }
}
