using System.Windows;
using Microsoft.Practices.Unity;
using Altium.NewProjectDialog.CompositionRoot;

namespace Altium.NewProjectDialog
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private IUnityContainer _iocContainer;

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            RegisterDependencies();
        }

        private void RegisterDependencies()
        {
            _iocContainer = new UnityContainer();
            DependenciesRegistrator.Register(_iocContainer);
        }
    }
}
