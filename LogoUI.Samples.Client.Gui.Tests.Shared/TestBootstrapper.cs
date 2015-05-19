using LogoFX.UI.Bootstrapping.SimpleContainer;
using BootstrapperBase = LogoUI.Samples.Client.Gui.Shell.BootstrapperBase;

namespace LogoUI.Samples.Gui.Tests.Shared
{
    public class TestBootstrapper : BootstrapperBase
    {        
        public TestBootstrapper(ExtendedSimpleIocContainer iocContainer) : base(iocContainer,useApplication:false)
        {
        }
    }
}
