using LogoUI.Samples.Gui.Tests.Shared;
using NUnit.Framework;

namespace LogoUI.Samples.Gui.Tests.Integration
{
    [TestFixture]
    [Category("Integration")]
    public class ShellLoadingTests : IntegrationTestsBase
    {        
        [Test]
        public void Initialization_DoesNotThrow()
        {           
            Assert.DoesNotThrow(() => CreateRootObject());
        }
    }
}
