using System.Windows.Threading;
using Caliburn.Micro;
using LogoFX.UI.Bootstrapping.SimpleContainer;
using LogoFX.UI.Tests.Infra;
using LogoUI.Samples.Client.Gui.Shell.ViewModels;
using NUnit.Framework;
using Solid.Fake.Moq;
using Solid.Practices.Scheduling;
using Solid.Tests.NUnit;

namespace LogoUI.Samples.Gui.Tests.Integration
{
    [TestFixture]
    [Category("Integration")]
    public class ShellLoadingTests : IntegrationTestsBase<ExtendedSimpleIocContainer,FakeFactory,ShellViewModel,TestBootstrapper>
    {
        protected override ShellViewModel CreateRootObjectOverride(ShellViewModel rootObject)
        {
            ScreenExtensions.TryActivate(rootObject);
            return rootObject;
        }

        [Test]
        public void Initialization_DoesNotThrow()
        {
            TaskScheduler.Current = new SameThreadTaskScheduler();
            Dispatch.Current = new SameThreadDispatch();

            Assert.DoesNotThrow(() => CreateRootObject());
        }
    }
}
