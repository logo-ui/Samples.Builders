using Attest.Fake.Moq;
using Attest.Tests.NUnit;
using Caliburn.Micro;
using LogoFX.UI.Bootstrapping.SimpleContainer;
using LogoUI.Samples.Client.Gui.Shell.ViewModels;

namespace LogoUI.Samples.Gui.Tests.Shared
{
    public abstract class IntegrationTestsBase : IntegrationTestsBase<ExtendedSimpleIocContainer, FakeFactory, ShellViewModel, TestBootstrapper>
    {
        protected override ShellViewModel CreateRootObjectOverride(ShellViewModel rootObject)
        {
            ScreenExtensions.TryActivate(rootObject);
            return rootObject;
        }
    }
}
