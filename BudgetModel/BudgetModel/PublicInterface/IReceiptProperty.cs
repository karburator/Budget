namespace BudgetModel.PublicInterface
{
    public interface IReceiptProperty : IDataModel
    {
        int Id { get; set; }

        /// <summary>Наименование дополнительного реквизита.</summary>
        string Key { get; set; }
        /// <summary>Значение дополнительного реквизита.</summary>
        string Value { get; set; }
    }
}
