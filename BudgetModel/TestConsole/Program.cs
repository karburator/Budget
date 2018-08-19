using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using BudgetModel.DataContext;
using BudgetModel.Model;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using(BudgetContext context = new BudgetContext(@"Data Source=FG-DUNIN\WS100500;Initial Catalog=BudgetModel.DataContext.BudgetContext;Integrated Security=True;MultipleActiveResultSets=True"))
            {
                var vv = context.Goods.ToList();
                context.SaveChanges();
            }

        }
    }

}
