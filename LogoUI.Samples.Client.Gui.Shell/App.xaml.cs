using LogoFX.UI.Bootstrapping.SimpleContainer;

namespace LogoUI.Samples.Client.Gui.Shell
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App
	{
	    public App()
	    {
	        var container = new ExtendedSimpleIocContainer();
	        new AppBootstrapper(container);
	    }
	}
}
