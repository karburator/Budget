using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BudgetFIleListner.Parse.Json;
using BudgetModel.DataContext;
using BudgetModel.Model;

namespace BudgetFIleListner
{
    public class FileListner
    {
        private FileSystemWatcher watcher;
        private object obj = new object();
        private bool enabled = true;
        private string dbConnectStr;
        private BudgetContext context;

        public FileListner(string dbConnectStr)
        {
            this.dbConnectStr = dbConnectStr;
            context = new BudgetContext(dbConnectStr);

            watcher = new FileSystemWatcher("D:\\Temp");
            watcher.Deleted += Watcher_Deleted;
            watcher.Created += Watcher_Created;
            watcher.Changed += Watcher_Changed;
            watcher.Renamed += Watcher_Renamed;
        }

        public void Start()
        {
            watcher.EnableRaisingEvents = true;
            while (enabled)
            {
                Thread.Sleep(1000);
            }
        }

        public void Stop()
        {
            watcher.EnableRaisingEvents = false;
            enabled = false;
        }

        // переименование файлов
        private void Watcher_Renamed(object sender, RenamedEventArgs e)
        {
            string fileEvent = "переименован в " + e.FullPath;
            string filePath = e.OldFullPath;
            RecordEntry(fileEvent, filePath);
        }

        // изменение файлов
        private void Watcher_Changed(object sender, FileSystemEventArgs e)
        {
            string fileEvent = "изменен";
            string filePath = e.FullPath;
            RecordEntry(fileEvent, filePath);
        }

        // создание файлов
        private void Watcher_Created(object sender, FileSystemEventArgs e)
        {
            string fileEvent = "создан";
            string filePath = e.FullPath;
            RecordEntry(fileEvent, filePath);

            JsonParser parser = new JsonParser();
            ReceiptModel model = parser.ParseFile(e.FullPath);

            ModelConverter converter = new ModelConverter(context);
            Receipt receipt = converter.Convert(model);

            bool isExist = context.Receipts.Any(el =>
                el.Date == receipt.Date
                && el.UserInn == receipt.UserInn
                && el.FiscalDocumentNumber == receipt.FiscalDocumentNumber);

            if (!isExist)
            {
                context.Receipts.Add(receipt);
                context.SaveChanges();
            }
        }

        // удаление файлов
        private void Watcher_Deleted(object sender, FileSystemEventArgs e)
        {
            string fileEvent = "удален";
            string filePath = e.FullPath;
            RecordEntry(fileEvent, filePath);
        }

        private void RecordEntry(string fileEvent, string filePath)
        {
            lock (obj)
            {
                using (StreamWriter writer = new StreamWriter("D:\\templog.txt", true))
                {
                    writer.WriteLine(String.Format("{0} файл {1} был {2}",
                        DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss"), filePath, fileEvent));
                    writer.Flush();
                }
            }
        }
    }
}