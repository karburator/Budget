namespace BudgetModel.PublicInterface
{
    public interface IOperationType : IDataModel
    {
        int Id { get; set; }
        string Description { get; set; }
    }
}
