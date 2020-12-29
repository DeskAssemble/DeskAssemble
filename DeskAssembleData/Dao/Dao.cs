using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeskAssembleData.Dao
{
    public class Dao
    {
        public static OrderDao Order { get; } = new OrderDao();
        public static CountryDao Country { get; } = new CountryDao();
        public static ExpenseDao Expense { get; } = new ExpenseDao();
        public static ItemDao Item { get; } = new ItemDao();
        public static MovementDao Movement { get; } = new MovementDao();
        public static TeamDao Team { get; } = new TeamDao();
        public static WareHouseDao WareHouse { get; } = new WareHouseDao();
        public static ContractDao Contract { get; } = new ContractDao();
    }
}
