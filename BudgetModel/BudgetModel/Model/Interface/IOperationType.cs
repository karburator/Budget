using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetModel.Model
{
    public interface IOperationType : IDataModel
    {
        int Id { get; set; }
        string Description { get; set; }
    }
}
