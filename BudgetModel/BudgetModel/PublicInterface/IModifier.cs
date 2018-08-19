namespace BudgetModel.PublicInterface
{
    public interface IModifier : IDataModel
    {
        int Id { get; set; }

        /// <summary>Наименование скидки.</summary>
        string DiscountName { get; set; }
        /// <summary>Наименование наценки.</summary>
        string MarkupName { get; set; }
        /// <summary>Скидка (ставка).</summary>
        decimal Discount { get; set; }
        /// <summary>Наценка (ставка).</summary>
        decimal Markup { get; set; }
        /// <summary>Скидка (сумма), в копейках.</summary>
        decimal DiscountSum { get; set; }
        /// <summary>yНаценка (сумма), в копейках.</summary>
        decimal MarkupSum { get; set; }
    }
}
