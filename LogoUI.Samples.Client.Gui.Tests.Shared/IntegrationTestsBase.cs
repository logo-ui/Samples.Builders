using LogoFX.UI.Bootstrapping.SimpleContainer;
using LogoUI.Samples.Client.Gui.Shell.ViewModels;
using Solid.Fake.Moq;
using Solid.Tests.NUnit;

namespace LogoUI.Samples.Gui.Tests.Shared
{
    public abstract class IntegrationTestsBase : IntegrationTestsBase<ExtendedSimpleIocContainer, FakeFactory, ShellViewModel, TestBootstrapper>
    {
    }
}
