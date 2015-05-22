using System.Windows.Threading;
using Attest.Fake.Moq;
using LogoFX.UI.Bootstrapping.SimpleContainer;
using LogoFX.UI.Tests.Core;
using LogoFX.UI.Tests.Infra;
using LogoUI.Samples.Client.Gui.Shell.ViewModels;
using Solid.Practices.Scheduling;

namespace LogoUI.Samples.Gui.Tests.Shared
{
    public abstract class IntegrationTestsBase : TestsBase<ExtendedSimpleIocContainer, FakeFactory, ShellViewModel, TestBootstrapper>
    {
        protected override void SetupOverride()
        {
            base.SetupOverride();
            TaskScheduler.Current = new SameThreadTaskScheduler();
            Dispatch.Current = new SameThreadDispatch();
        }
    }
}
