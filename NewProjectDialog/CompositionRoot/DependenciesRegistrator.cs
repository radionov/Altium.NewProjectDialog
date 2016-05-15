using System;
using Microsoft.Practices.Unity;

namespace Altium.NewProjectDialog.CompositionRoot
{
    static class DependenciesRegistrator
    {
        public static void Register(IUnityContainer iocContainer)
        {
            if (iocContainer == null)
                throw new ArgumentNullException(nameof(iocContainer));
        }
    }
}
