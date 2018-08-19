using BudgetModel.PublicInterface;

namespace BudgetModel.Model
{
    public class OperationType : IOperationType
    {
        public int EntityId => BudgetModelConstants.OperationTypeEntityId;

        public int Id { get; set; }
        public string Description { get; set; }
    }
}
