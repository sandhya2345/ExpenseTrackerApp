using BlazorDownloadFile;
using m2.Services;
using Microsoft.Extensions.Logging;

namespace m2
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });
            builder.Services.AddSingleton<HttpClient>(new HttpClient { BaseAddress = new Uri("https://v6.exchangerate-api.com/v6/0fea5277f5d05d3cb5e8d1d5") });


            builder.Services.AddScoped<UserService>();
            builder.Services.AddScoped<CurrencyService>();
           builder.Services.AddBlazorDownloadFile();


            builder.Services.AddMauiBlazorWebView();

#if DEBUG
    		builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
