using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Practices.Unity;
using Altium.NewProjectDialog.ViewModels;

namespace Altium.NewProjectDialog.CompositionRoot
{
    static class DependenciesRegistrator
    {
        public static void Register(IUnityContainer iocContainer)
        {
            if (iocContainer == null)
                throw new ArgumentNullException(nameof(iocContainer));

            iocContainer.RegisterType<Window, MainWindow>(new ContainerControlledLifetimeManager());
            iocContainer.RegisterType<TreeViewViewModel>();
            //iocContainer.RegisterType<ITrafficServer, TrafficServer>();
            //iocContainer.RegisterType<IGateConnection>(new InjectionFactory((c, t, s) => GateConnectionLayer.Instance?.Connection));

            //RegisterObjectMapping(iocContainer);
        }
    }
}
