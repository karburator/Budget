using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.ServiceProcess;
using System.Threading.Tasks;

namespace BudgetFIleListner
{
    [RunInstaller(true)]
    public partial class BudgetFileListnerInstaller : System.Configuration.Install.Installer
    {
        readonly ServiceInstaller serviceInstaller;
        ServiceProcessInstaller processInstaller;

        public BudgetFileListnerInstaller()
        {
            InitializeComponent();
            serviceInstaller = new ServiceInstaller();
            processInstaller = new ServiceProcessInstaller();

            processInstaller.Account = ServiceAccount.LocalSystem;
            serviceInstaller.StartType = ServiceStartMode.Manual;
            serviceInstaller.ServiceName = "BudgetFileListner";
            Installers.Add(processInstaller);
            Installers.Add(serviceInstaller);
        }
    }
}
