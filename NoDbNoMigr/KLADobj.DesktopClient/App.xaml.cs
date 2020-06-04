using Microsoft.Extensions.DependencyInjection;
using KLADobj.ApplicationServices.GetFreeListUseCase;
using KLADobj.ApplicationServices.Ports.Cache;
using KLADobj.ApplicationServices.Repositories;
using KLADobj.DesktopClient.InfrastructureServices.ViewModels;
using KLADobj.DomainObjects;
using KLADobj.DomainObjects.Ports;
using KLADobj.InfrastructureServices.Cache;
using KLADobj.InfrastructureServices.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace KLADobj.DesktopClient
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly ServiceProvider _serviceProvider;

        public App()
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            _serviceProvider = serviceCollection.BuildServiceProvider();
        }

        private void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IDomainObjectsCache<kladobj>, DomainObjectsMemoryCache<kladobj>>();
            services.AddSingleton<NetworkKLADobjRepository>(
                x => new NetworkKLADobjRepository("localhost", 80, useTls: false, x.GetRequiredService<IDomainObjectsCache<kladobj>>())
            );
            services.AddSingleton<CachedReadOnlyKLADobjRepository>(
                x => new CachedReadOnlyKLADobjRepository(
                    x.GetRequiredService<NetworkKLADobjRepository>(), 
                    x.GetRequiredService<IDomainObjectsCache<kladobj>>()
                )
            );
            services.AddSingleton<IReadOnlyKLADobjRepository>(x => x.GetRequiredService<CachedReadOnlyKLADobjRepository>());
            services.AddSingleton<IGetKLADobjListUseCase, GetKLADobjListUseCase>();
            services.AddSingleton<MainViewModel>();
            services.AddSingleton<MainWindow>();
        }

        private void OnStartup(object sender, StartupEventArgs args)
        {
            var mainWindow = _serviceProvider.GetService<MainWindow>();
            mainWindow.Show();
        }
    }
}
