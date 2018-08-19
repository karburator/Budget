using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.Text;

namespace BudgetFIleListner.Parse.Json
{
    public class JsonParser
    {
        public JsonParser()
        {
            JsConfig.DateHandler = DateHandler.UnixTime;
        }

        public ReceiptModel ParseFile(string filePath)
        {
            using(FileStream fileStream = new FileStream(filePath, FileMode.Open))
            {
                using(StreamReader reader = new StreamReader(fileStream))
                {
                    string json = reader.ReadToEnd();
                    ReceiptModel model = GetReceiptModel(json);
                    return model;
                }
            }
        }

        public ReceiptModel GetReceiptModel(string json)
        {
            try
            {
                ReceiptModel receipt = JsonSerializer.DeserializeFromString<ReceiptModel>(json);
                return receipt;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
