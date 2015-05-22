using System.Linq;
using LogoUI.Samples.Client.Data.Providers.Contracts;
using LogoUI.Samples.Client.Gui.Modularity.ViewModels;
using LogoUI.Samples.Client.Gui.Modules.Compliance.ViewModels;
using LogoUI.Samples.Client.Gui.Shell.ViewModels;
using LogoUI.Samples.Client.Gui.Tests.Fake;
using LogoUI.Samples.Fake.Builders;
using LogoUI.Samples.Gui.Tests.Shared;
using NUnit.Framework;

namespace LogoUI.Samples.Gui.Tests.Integration
{
    [TestFixture]
    [Category("Integration")]
    public class ComplianceLoadingTests : IntegrationTestsBase
    {        
        [Test]
        public void ServerReturnsComplianceRecords_ComplianceScreenIsAccessed_ComplianceRecordsAreDisplayed()
        {            
            RegisterService<ILoginProvider>(new FakeTestLoginProvider());
            const int numberOfRecords = 100;
            RegisterBuilder(ComplianceProviderBuilder.CreateBuilder().WithComplianceRecord(numberOfRecords));

            var rootObject = CreateRootObject();
            var loginViewModel = (LoginViewModel)rootObject.ActiveItem;
            loginViewModel.SelectedLogin = "Local Authentication";
            loginViewModel.LoginCommand.Execute(null);
            var mainViewModel = (MainViewModel) rootObject.ActiveItem;
            var firstModule = mainViewModel.Modules.OfType<ModuleViewModel>().First(t => t.Name == "Compliance");
            var moduleRootViewModel = (ComplianceRootViewModel)(firstModule.RootViewModel);

            var complianceRecords =
                moduleRootViewModel.ConsoleViewModel.ListViewModel.Items.OfType<ComplianceRecordViewModel>();
            Assert.AreEqual(numberOfRecords,complianceRecords.Count());

        }
    }
}
