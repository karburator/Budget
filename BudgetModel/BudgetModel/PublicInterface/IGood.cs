using System.Collections.Generic;
using BudgetModel.Model;

namespace BudgetModel.PublicInterface
{
    public interface IGood : IDataModel
    {
        int Id { get; set; }

        /// <summary>Наименование товара.</summary>
        string Name { get; set; }
        /// <summary>Штриховой код EAN13,</summary>
        string Barcode { get; set; }
        /// <summary>Цена за единицу.</summary>
        decimal Price { get; set; }
        /// <summary>Количество.</summary>
        decimal Quantity { get; set; }
        /// <summary>Скидка/надбавка.</summary>
        List<Modifier> Modifiers { get; set; }
        /// <summary>НДС итога чека с рассчитанной ставкой 18%, в копейках.</summary>
        decimal NdsCalculated18 { get; set; }
        /// <summary>НДС итога чека с рассчитанной ставкой 10%, в копейках.</summary>
        decimal NdsCalculated10 { get; set; }
        /// <summary>Общая стоимость позиции с учетом скидок и наценок.</summary>
        decimal Sum { get; set; }
        /// <summary>Дополнительный реквизит.</summary>
        List<ReceiptProperty> Properties { get; set; }
    }
}
