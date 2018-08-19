using System.Data.Entity;
using BudgetModel.Model;

namespace BudgetModel.PublicInterface
{
    public interface IBudgetContext
    {
        DbSet<IGood> Goods { get; set; }
        DbSet<IModifier> Modifiers { get; set; }
        DbSet<IOperationType> OperationTypes { get; set; }
        DbSet<IReceipt> Receipts { get; set; }
        DbSet<IReceiptProperty> RecieptPropertys { get; set; }
    }
}