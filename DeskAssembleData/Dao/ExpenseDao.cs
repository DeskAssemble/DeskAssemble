using DeskAssembleData.EFLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DeskAssembleData
{
    public class ExpenseDao
    {
        public List<Expense> GetExpenses()
        {
            using (DeskAssemblyEntities context = DbContextCreator.Create())
            {
                //Expense테이블에서 가져옴(이걸로 끝) 3건은 이걸로!!!!
                List<Expense> expenses = context.Expenses.ToList();

                //자원구매비는 이걸로 계산,x=order
                var query = from x in context.Orders
                            where x.IsSale == false
                            select new { Date = x.Date, Cost = x.Quantity * x.Item.Price };

                //갯수보기위한식(없어도됨)
                var list = query.ToList();
                
                //x=이름없는익명타입(여기안에는 cost,date라는 속성이있음)
                foreach(var x in list)
                {
                    Expense resourceExpense = new Expense();
                    resourceExpense.Name = "자원구매비";
                    resourceExpense.Date = x.Date;
                    resourceExpense.Cost = x.Cost;

                    expenses.Add(resourceExpense);
                }
                
                return expenses;
            }
        }
    }
}