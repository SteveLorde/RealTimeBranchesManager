using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Microsoft.Extensions.DependencyInjection;
using RealTimeBranchesManager.Services;

namespace RealTimeBranchesManager;

public class App : Application
{
	public override void Initialize()
	{
		AvaloniaXamlLoader.Load(this);
	}

	public override void OnFrameworkInitializationCompleted()
	{
		if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
			desktop.MainWindow = new MainWindow();

		var serviceCollection = new ServiceCollection();

		ServicesCollectionExtension.AddGeneralServices(serviceCollection);
		ServicesCollectionExtension.AddDbServices(serviceCollection);

		base.OnFrameworkInitializationCompleted();
	}
}