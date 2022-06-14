using Hanssens.Net;
using Microsoft.Extensions.DependencyInjection;
using ModTools.Presenter;
using ModTools.Presenter.Contracts;
using ModTools.Services;
using ModTools.Services.Contracts;
using ModTools.View;
using ModTools.View.Contracts;

namespace ModTools
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            // ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.SetCompatibleTextRenderingDefault(false);
            // Control.CheckForIllegalCrossThreadCalls = false;
            var services = new ServiceCollection();

            ConfigureServices(services);

            using var serviceProvider = services.BuildServiceProvider();
            var mainMenuPresenter = serviceProvider.GetRequiredService<IMainMenuPresenter>();
            mainMenuPresenter.Init();
            Application.Run(mainMenuPresenter.Form());
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddLogging()
                // presenters
                .AddScoped<IMainMenuPresenter, MainMenuPresenter>()
                .AddTransient<IRaceEditorPresenter, RaceEditorPresenter>()
                .AddTransient<IManageCitizenPortraitsPresenter, ManageCitizenPortraitsPresenter>()
                .AddTransient<IStarSystemEditorPresenter, StarSystemEditorPresenter>()
                .AddTransient<IOrbitLanePresenter, OrbitLanePresenter>()
                .AddTransient<IOrbitBodyPresenter, OrbitBodyPresenter>()
                .AddTransient<ISettingsPresenter, SettingsPresenter>()
                .AddTransient<IEventEditorPresenter, EventEditorPresenter>()

                // views
                .AddScoped<IMainMenuView, MainMenuForm>()
                .AddTransient<IRaceEditorView, RaceEditorForm>()
                .AddTransient<IRequestFolderView, RequestFolderView>()
                .AddTransient<IRequestImageFileView, RequestImageFileView>()
                .AddTransient<IGlobalStatView, GlobalStatForm>()
                .AddTransient<IColonyStatView, ColonyStatForm>()
                .AddTransient<IApprovalModifierView, ApprovalModifierForm>()
                .AddTransient<IManageCitizenPortraitsView, ManageCitizenPortraitsForm>()
                .AddTransient<IStarSystemEditorView, StarSystemEditorForm>()
                .AddTransient<IOrbitLaneView, OrbitLaneForm>()
                .AddTransient<IOrbitBodyView, OrbitBodyForm>()
                .AddTransient<ISettingsView, SettingsForm>()
                .AddTransient<IGenericDialogView, GenericDialog>()
                .AddTransient<IEventEditorView, EventEditorForm>()
                
                // other
                .AddSingleton<ISettingsService, SettingsService>()
                .AddSingleton<IGameFileCacheService, GameFileCacheService>()
                .AddScoped<IImageService, ImageSharpImageService>()
                .AddScoped<IRaceService, RaceService>()
                .AddScoped<ISpaceService, SpaceService>()
                .AddScoped<LocalStorage>();
        }
    }
}