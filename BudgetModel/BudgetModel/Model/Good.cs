using System.Collections.Generic;
using BudgetModel.PublicInterface;

namespace BudgetModel.Model
{
    public class Good : IGood
    {
        public int EntityId => BudgetModelConstants.GoodEntityId;

        public int Id { get; set; }

        /// <summary>Наименование товара.</summary>
        public string Name { get; set; }
        /// <summary>Штриховой код EAN13,</summary>
        public string Barcode { get; set; }
        /// <summary>Цена за единицу.</summary>
        public decimal Price { get; set; }
        /// <summary>Количество.</summary>
        public decimal Quantity { get; set; }
        /// <summary>Скидка/надбавка.</summary>
        public List<Modifier> Modifiers { get; set; }
        /// <summary>НДС итога чека со ставкой 18%, в копейках.</summary>
        public decimal Nds18 { get; set; }
        /// <summary>НДС итога чека со ставкой 10%, в копейках.</summary>
        public decimal Nds10 { get; set; }
        /// <summary>НДС итога чека со ставкой 0%, в копейках.</summary>
        public decimal Nds0 { get; set; }
        /// <summary>НДС не облагается.</summary>
        public decimal NdsNo { get; set; }
        /// <summary>НДС итога чека с рассчитанной ставкой 18%, в копейках.</summary>
        public decimal NdsCalculated18 { get; set; }
        /// <summary>НДС итога чека с рассчитанной ставкой 10%, в копейках.</summary>
        public decimal NdsCalculated10 { get; set; }
        /// <summary>Общая стоимость позиции с учетом скидок и наценок.</summary>
        public decimal Sum { get; set; }
        /// <summary>Дополнительный реквизит.</summary>
        public List<ReceiptProperty> Properties { get; set; }
    }
}
