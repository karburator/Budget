using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using BudgetModel.Model;

namespace BudgetModel.DataContext
{
    public class BudgetContext : DbContext
    {
        public BudgetContext(string dbConnectStr)
            : base(dbConnectStr)
        {
        }

        public DbSet<Good> Goods { get; set; }
        public DbSet<Modifier> Modifiers { get; set; }
        public DbSet<OperationType> OperationTypes { get; set; }
        public DbSet<Receipt> Receipts { get; set; }
        public DbSet<ReceiptProperty> RecieptPropertys { get; set; }

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