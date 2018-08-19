using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetModel.Model
{
    public class ReceiptProperty : IReceiptProperty
    {
        public int EntityId => BudgetModelConstants.ReceiptProperty_Entity_Id;

        public int Id { get; set; }

        /// <summary>Наименование дополнительного реквизита.</summary>
        public string Key { get; set; }
        /// <summary>Значение дополнительного реквизита.</summary>
        public string Value { get; set; }
    }
}
