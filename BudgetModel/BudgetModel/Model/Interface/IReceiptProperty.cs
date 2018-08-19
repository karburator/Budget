using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetModel.Model
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
