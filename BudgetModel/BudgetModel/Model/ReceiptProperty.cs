using BudgetModel.PublicInterface;

namespace BudgetModel.Model
{
    public class ReceiptProperty : IReceiptProperty
    {
        public int EntityId => BudgetModelConstants.ReceiptPropertyEntityId;

        public int Id { get; set; }

        /// <summary>Наименование дополнительного реквизита.</summary>
        public string Key { get; set; }
        /// <summary>Значение дополнительного реквизита.</summary>
        public string Value { get; set; }
    }
}
