using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BudgetFIleListner
{
    public partial class BudgetFileListnerService : ServiceBase
    {
        private FileListner fileListner;
        public BudgetFileListnerService()
        {
            InitializeComponent();
            CanStop = true;
            CanPauseAndContinue = true;
            AutoLog = true;
        }

        protected override void OnStart(string[] args)
        {
            // Ждем тут такой параметр - строка подключения.
            // "Data Source=FG-DUNIN\WS100500;Initial Catalog=BudgetModel;Integrated Security=False;User Id=sa;Password=sapwd;MultipleActiveResultSets=True"
            string dbConnectStr = String.Empty;
            if(args.Length > 0)
                dbConnectStr = args[0];

            fileListner = new FileListner(dbConnectStr);
            Thread loggerThread = new Thread(new ThreadStart(fileListner.Start));
            loggerThread.Start();
        }
 
        protected override void OnStop()
        {
            fileListner.Stop();
            Thread.Sleep(1000);
        }
    }
}
