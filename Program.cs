using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc.Razor;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddLocalization(o => { o.ResourcesPath = "Resources"; });
builder.Services.Configure<RequestLocalizationOptions>(options =>{
    options.SetDefaultCulture("vi-VN");
    options.AddSupportedUICultures("en-US", "vi-VN");
    options.FallBackToParentUICultures = true;
    //options.RequestCultureProviders.Clear();
    options.RequestCultureProviders = new List<IRequestCultureProvider>{
        new QueryStringRequestCultureProvider(),
        new CookieRequestCultureProvider(),
    };
});
builder.Services.AddControllersWithViews()
    .AddViewLocalization(LanguageViewLocationExpanderFormat.SubFolder)
    .AddDataAnnotationsLocalization();

var app = builder.Build();

app.UseRequestLocalization();
app.UseStaticFiles();
app.UseRequestLocalization();
app.MapDefaultControllerRoute();





app.Run();
