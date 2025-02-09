using Foundation;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace OtpApp
{
    [Register("AppDelegate")]
    public class AppDelegate : MauiUIApplicationDelegate
    {
        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
    }
}
