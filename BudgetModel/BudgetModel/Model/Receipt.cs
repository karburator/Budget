using System;
using System.Collections.Generic;
using BudgetModel.PublicInterface;

namespace BudgetModel.Model
{
    public class Receipt : IReceipt
    {
        public Receipt()
        {
            Items = new List<Good>();
            StornoItems = new List<Good>();
            Modifiers = new List<Modifier>();
        }

        public int EntityId => BudgetModelConstants.ReceiptEntityId;

        public int Id { get; set; }

        /// <summary>Наименование пользователя.</summary>
        public string User { get; set; }
        /// <summary>ИНН пользователя.</summary>
        public string UserInn { get; set; }
        /// <summary>Номер чека за смену.</summary>
        public int RequestNumber { get; set; }
        /// <summary>Дата, время.</summary>
        public DateTime Date { get; set; }
        /// <summary>Номер смены.</summary>
        public int ShiftNumber { get; set; }
        /// <summary>Признак расчета.</summary>
        public OperationType OperationType { get; set; }
        /// <summary>Применяемая система налогообложения.</summary>
        public int TaxationType { get; set; }
        /// <summary>Кассир.</summary>
        public string Operator { get; set; }
        /// <summary>Регистрационный номер ККТ.</summary>
        public string KktRegId { get; set; }
        /// <summary>Заводской номер фискального накопителя.</summary>
        public string FiscalDriveNumber { get; set; }
        /// <summary>Адрес (место) расчетов.</summary>
        public string RetailPlaceAddress { get; set; }

        /// <summary>Наименование товара (реквизиты).</summary>
        public List<Good> Items { get; set; }
        /// <summary>Сторно товара (реквизиты).</summary>
        public List<Good> StornoItems { get; set; }
        /// <summary>Скидка/наценка.</summary>
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
        /// <summary>ИТОГ, в копейках.</summary>
        public decimal TotalSum { get; set; }
        /// <summary>Сумма уплаченная наличными, в копейках.</summary>
        public decimal CashTotalSum { get; set; }
        /// <summary>Сумма уплаченная электронными средствами платежа, в копейках.</summary>
        public decimal EcashTotalSum { get; set; }
        /// <summary>Порядковый номер фискального документа.</summary>
        public int FiscalDocumentNumber { get; set; }
        /// <summary>Фискальный номер документа.</summary>
        public int FiscalSign { get; set; }

        #region Этих парней нет в примерах
        ///// <summary>Адрес покупателя.</summary>
        //public string BuyerAddress { get; set; }
        ///// <summary>Адрес отправителя.</summary>
        //public string SenderAddress { get; set; }
        ///// <summary>Адрес сайта для проверки ФП.</summary>
        //public string AddressToCheckFiscalSign { get; set; }
        ///// <summary>Размер вознаграждения платежного агента (субагента), в копейках.</summary>
        //public decimal paymentAgentRemuneration { get; set; }
        ///// <summary>Телефон платежного агента.</summary>
        //public string PaymentAgentPhone { get; set; }
        ///// <summary>Телефон платежного субагента.</summary>
        //public string AymentSubagentPhone { get; set; }
        ///// <summary>Телефон оператора по приему платежей.</summary>
        //public string OperatorPhoneToReceive { get; set; }
        ///// <summary>Телефон оператора по переводу денежных средств.</summary>
        //public string OperatorPhoneToTransfer { get; set; }
        ///// <summary>Телефон банковского агента.</summary>
        //public string BankAgentPhone { get; set; }
        ///// <summary>Телефон банковского субагента.</summary>
        //public string BankSubagentPhone { get; set; }
        ///// <summary>Операция банковского агента.</summary>
        //public string BankAgentOperation { get; set; }
        ///// <summary>Операция банковского субагента.</summary>
        //public string BankSubagentOperation { get; set; }
        ///// <summary>Размер вознаграждения банковского агента (субагента).</summary>
        //public decimal BankAgentRemuneration { get; set; }
        ///// <summary>Наименование оператора по переводу денежных средств.</summary>
        //public string OperatorName { get; set; }
        ///// <summary>Адрес оператора по переводу денежных средств.</summary>
        //public string OperatorAddress { get; set; }
        ///// <summary>ИНН оператора по переводу денежных средств.</summary>
        //public string OperatorInn { get; set; }
        ///// <summary>Дополнительный реквизит.</summary>
        //public List<RecieptProperty> Properties { get; set; }
        ///// <summary>Бинарное представление документа в формате протокола ККТ с ФП2.</summary>
        //public string RawData { get; set; }
        ///// <summary>Код документа "Кассовый чек" (всегда равен 3).</summary>
        //public int ReceiptCode { get; set; }
        ///// <summary>код Документа "БСО" (всегда равен 4).</summary>
        //public int BsoCode { get; set; }
        #endregion

    }
}
