using MauiAppJnilibSample.Pages;

namespace MauiAppJnilibSample;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        MainPage = new AppBootstrapper().Bootstrap().CreateMainPage();
	}
}
