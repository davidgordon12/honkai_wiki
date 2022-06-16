using honkai_wiki;
using honkai_wiki.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => 
    new HttpClient 
    { 
        BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) 
    });

builder.Services.AddScoped(sp =>
    new HttpClient
    {
        BaseAddress = new Uri("https://localhost:7061")
    });

builder.Services.AddScoped<IHonkaiService, ValkyrieService>();
builder.Services.AddScoped<IHonkaiService, BattlesuitService>();
builder.Services.AddScoped<IHonkaiService, WeaponService>();
builder.Services.AddScoped<IHonkaiService, StigmataService>();

await builder.Build().RunAsync();
