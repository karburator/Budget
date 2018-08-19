using System;
using BudgetFIleListner.Parse.Json;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServiceStack.Text;

namespace BudgetTests.BudgetFileListnerTests
{
    [TestClass]
    public class JsonParserTest
    {
        [TestMethod]
        public void ParseDateToModel()
        {
            // Data
            string jsonDate = "{\"dateTime\":1530267180}";
            DateTime date = new DateTime(2018, 06, 29, 10, 13, 00);
            JsonParser jsonParser = new JsonParser();

            // Act
            ReceiptModel model = jsonParser.GetReceiptModel(jsonDate);

            // Assert
            Assert.AreEqual(date, model.DateTime);
        }

        [TestMethod]
        public void ParseReceiptItem()
        {
            // Data
            string name = "Мега сет";
            decimal nds0 = 1;
            decimal nds10 = 2;
            decimal nds18 = 3;
            decimal ndsCalculated10 = 4;
            decimal ndsCalculated18 = 5;
            decimal ndsNo = 6;
            decimal price = 7;
            decimal quantity = 8.0m;
            decimal sum = 9;
            string jsonItem = $"{{\"modifiers\": null,\"name\": \"{name}\",\"nds0\": {nds0}," +
                              $"\"nds10\": {nds10},\"nds18\": {nds18}," +
                              $"\"ndsCalculated10\": {ndsCalculated10}," +
                              $"\"ndsCalculated18\": {ndsCalculated18}," +
                              $"\"ndsNo\": {ndsNo},\"price\": {price}," +
                              $"\"quantity\": 8.0,\"sum\": {sum},\"storno\": false}}";

            // Act
            GoodModel mode = JsonSerializer.DeserializeFromString<GoodModel>(jsonItem);

            // Assert
            Assert.AreEqual(null, mode.Modifiers);
            Assert.AreEqual(name, mode.Name);
            Assert.AreEqual(nds0, mode.Nds0);
            Assert.AreEqual(nds10, mode.Nds10);
            Assert.AreEqual(nds18, mode.Nds18);
            Assert.AreEqual(ndsCalculated10, mode.NdsCalculated10);
            Assert.AreEqual(ndsCalculated18, mode.NdsCalculated18);
            Assert.AreEqual(ndsNo, mode.NdsNo);
            Assert.AreEqual(price, mode.Price);
            Assert.AreEqual(quantity, mode.Quantity);
            Assert.AreEqual(sum, mode.Sum);
        }
    }
}
