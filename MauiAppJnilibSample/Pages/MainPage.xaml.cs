using MauiAppJnilibSample.ViewModels;
using ReactiveUI;
using ReactiveUI.Maui;
using System.Reactive.Disposables;
using System.Reactive.Linq;

namespace MauiAppJnilibSample.Pages;

public partial class MainPage : BasePage<MainPageViewModel>
{
	public MainPage()
	{
		InitializeComponent();

		this.WhenActivated(disposable =>
		{
			this.OneWayBind(ViewModel, vm => vm.StringList, v => v.LstStrings.ItemsSource)
				.DisposeWith(disposable);

			this.BindCommand(ViewModel, vm => vm.StartReadingCommand, v => v.BtnStart)
                .DisposeWith(disposable);

			this.WhenAnyValue(vm => vm.ViewModel.StartReadingCommand)
				.Subscribe();
        });
	}
}