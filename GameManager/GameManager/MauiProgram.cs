namespace GameManager;

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

#pragma warning disable CA1416 // Validate platform compatibility
        builder.Services.AddMauiBlazorWebView();
#pragma warning restore CA1416 // Validate platform compatibility

        builder.Services.AddBlazorise(options =>
            {
                options.Immediate = true;
            })
            .AddMaterialProviders()
            .AddMaterialIcons();
#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
#endif

        return builder.Build();
    }
}
