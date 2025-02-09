using Microsoft.Maui;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Hosting;

namespace OtpApp
{
    public class Program : MauiApplication
    {
        public Program()
            : base()
        {
        }

        // The main entry point for the application.
        public static void Main(string[] args)
        {
            CreateMauiApp().Run(args);
        }

        // Creates the MAUI app and configures services
        static IAppHostBuilder CreateMauiApp() =>
            MauiApp.CreateBuilder()
                .UseMauiApp<App>()  // Specify the App class (the entry point for resources, pages, etc.)
                .ConfigureServices(services =>
                {
                    // Register any services you need here (e.g., SMS service, authentication services, etc.)
                    // services.AddSingleton<ISmsService, SmsService>(); // Example for dependency injection
                })
                .ConfigureFonts(fonts =>
                {
                    // Configure the fonts that the app will use
                    fonts.AddFont("Arial.ttf", "ArialRegular");
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });
    }
}
.ConfigureServices(services =>
 {
     services.AddSingleton<ISmsService, SmsService>();
 });
.ConfigureFonts(fonts =>
 {
     fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
 });
