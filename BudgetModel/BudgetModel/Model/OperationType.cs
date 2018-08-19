using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetModel.Model
{
    public class OperationType : IOperationType
    {
        public int EntityId => BudgetModelConstants.OperationType_Entity_Id;

        public int Id { get; set; }
        public string Description { get; set; }
    }
}
