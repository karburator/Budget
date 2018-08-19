using System.Data.Entity;
using BudgetModel.Model;
using BudgetModel.PublicInterface;

namespace BudgetModel.DataContext
{
    public class BudgetContext : DbContext, IBudgetContext
    {public BudgetContext(string dbConnectStr)
                 : base(dbConnectStr)
             {
             }
        

        public DbSet<IGood> Goods { get; set; }
        public DbSet<IModifier> Modifiers { get; set; }
        public DbSet<IOperationType> OperationTypes { get; set; }
        public DbSet<IReceipt> Receipts { get; set; }
        public DbSet<IReceiptProperty> RecieptPropertys { get; set; }

        public Receipt CreateEmptyReceipt()
        {
            return new Receipt();
        }

        public OperationType CreateEmptyOperationType()
        {
            return new OperationType();
        }

        public Good CreateEmptyGood()
        {
            return new Good();
        }

        public Modifier CrateEmptyModifier()
        {
            return new Modifier();
        }

        public ReceiptProperty CreateEmptyReceiptProperty()
        {
            return new ReceiptProperty();
        }
    }
}