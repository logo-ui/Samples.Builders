using System.Windows.Threading;
using Caliburn.Micro;
using LogoFX.UI.Tests.Infra;
using LogoUI.Samples.Client.Gui.Shell.ViewModels;
using LogoUI.Samples.Gui.Tests.Shared;
using NUnit.Framework;
using Solid.Practices.Scheduling;

namespace LogoUI.Samples.Gui.Tests.Integration
{
    [TestFixture]
    [Category("Integration")]
    public class ShellLoadingTests : IntegrationTestsBase
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
