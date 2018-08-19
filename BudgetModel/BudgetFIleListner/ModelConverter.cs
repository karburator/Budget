using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BudgetFIleListner.Parse.Json;
using BudgetModel.DataContext;
using BudgetModel.Model;

namespace BudgetFIleListner
{
    public class ModelConverter
    {
        private const int CopecksInRouble = 100;
        private BudgetContext context;

        public ModelConverter(BudgetContext context)
        {
            this.context = context;
        }

        public ReceiptProperty Convert(ReceiptPropertyModel model)
        {
            ReceiptProperty receiptProperty = context.CreateEmptyReceiptProperty();

            receiptProperty.Key = model.Key;
            receiptProperty.Value = model.Value;

            return receiptProperty;
        }

        public OperationType ConvertOperationType(int id)
        {
            OperationType operationType = context.OperationTypes.FirstOrDefault(el => el.Id == id);
            if(operationType == null)
            {
                operationType = context.CreateEmptyOperationType();
                operationType.Id = id;
            }

            return operationType;
        }

        public Modifier Convert(ModifierModel model)
        {
            Modifier modifier = context.CrateEmptyModifier();

            modifier.Discount = model.Discount;
            modifier.DiscountName = model.DiscountName;
            modifier.DiscountSum = model.DiscountSum / CopecksInRouble;
            modifier.Markup = model.Markup;
            modifier.MarkupName = model.MarkupName;
            modifier.MarkupSum = model.MarkupSum / CopecksInRouble;

            return modifier;
        }

        public Good Convert(GoodModel model)
        {
            Good good = context.CreateEmptyGood();

            good.Barcode = model.Barcode;
            good.Name = model.Name;
            good.NdsNo = model.NdsNo;
            good.Nds0 = model.Nds0 / CopecksInRouble;
            good.Nds10 = model.Nds10 / CopecksInRouble;
            good.Nds18 = model.Nds18 / CopecksInRouble;
            good.NdsCalculated10 = model.NdsCalculated10 / CopecksInRouble;
            good.NdsCalculated18 = model.NdsCalculated18 / CopecksInRouble;
            good.Price = model.Price / CopecksInRouble;
            good.Quantity = model.Quantity;
            good.Sum = model.Sum / CopecksInRouble;

            foreach(ModifierModel item in model.Modifiers)
                good.Modifiers.Add(Convert(item));


            foreach(ReceiptPropertyModel property in model.Properties)
                good.Properties.Add(Convert(property));

            return good;
        }

        public Receipt Convert(ReceiptModel model)
        {
            Receipt receipt = context.CreateEmptyReceipt();

            receipt.User = model.User;
            receipt.UserInn = model.UserInn;
            receipt.RequestNumber = model.RequestNumber;
            receipt.Date = model.DateTime;
            receipt.ShiftNumber = model.ShiftNumber;
            receipt.OperationType = ConvertOperationType(model.OperationType);
            receipt.TaxationType = model.TaxationType;
            receipt.Operator = model.Operator;
            receipt.KktRegId = model.KktRegId;
            receipt.FiscalDriveNumber = model.FiscalDriveNumber;
            receipt.RetailPlaceAddress = model.RetailPlaceAddress;
            receipt.Nds18 = model.Nds18;
            receipt.Nds10 = model.Nds10;
            receipt.Nds0 = model.Nds0;
            receipt.NdsNo = model.NdsNo;
            receipt.NdsCalculated18 = model.NdsCalculated18;
            receipt.NdsCalculated10 = model.NdsCalculated10;
            receipt.TotalSum = model.TotalSum;
            receipt.CashTotalSum = model.CashTotalSum;
            receipt.EcashTotalSum = model.EcashTotalSum;
            receipt.FiscalDocumentNumber = model.FiscalDocumentNumber;
            receipt.FiscalSign = model.FiscalSign;

            foreach(GoodModel item in model.Items)
                receipt.Items.Add(Convert(item));

            foreach(GoodModel item in model.StornoItems)
                receipt.StornoItems.Add(Convert(item));

            foreach(ModifierModel item in model.Modifiers)
                receipt.Modifiers.Add(Convert(item));

            return receipt;
        }
    }
}
