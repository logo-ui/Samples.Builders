using System.Windows.Threading;
using LogoFX.UI.Tests.Infra;
using LogoUI.Samples.Gui.Tests.Shared;
using NUnit.Framework;
using Solid.Practices.Scheduling;

namespace LogoUI.Samples.Gui.Tests.Integration
{
    [TestFixture]
    [Category("Integration")]
    public class ShellLoadingTests : IntegrationTestsBase
    {
        protected override void TearDownOverride()
        {
            base.TearDownOverride();
            Caliburn.Micro.AssemblySource.Instance.Clear();
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
