using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetFIleListner.Parse.Json
{
    public class ReceiptPropertyModel
    {
        /// <summary>Наименование дополнительного реквизита.</summary>
        public string Key { get; set; }
        /// <summary>Значение дополнительного реквизита.</summary>
        public string Value { get; set; }
    }
}
