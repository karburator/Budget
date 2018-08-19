using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BudgetFIleListner;
using BudgetFIleListner.Parse.Json;
using BudgetModel.DataContext;
using BudgetModel.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace BudgetTests.BudgetFileListnerTests
{
    [TestClass]
    public class ModelConverterTest
    {
        [TestMethod]
        public void ReceiptPropertyModelConvertTest()
        {
            // Arange
            ReceiptPropertyModel model = new ReceiptPropertyModel()
            {
                Key = "Key",
                Value = "Value"
            };

            Mock<BudgetContext> contextModck = new Mock<BudgetContext>();
            ModelConverter converter = new ModelConverter(contextModck.Object);

            // Act
            ReceiptProperty result = converter.Convert(model);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(model.Key, result.Key);
            Assert.AreEqual(model.Value, result.Value);
        }
    }
}
