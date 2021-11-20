using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorApp.Client;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
var baseAddress = builder.Configuration["BaseAddress"] ?? builder.HostEnvironment.BaseAddress; 
builder.Services.AddScoped(_ => new HttpClient { BaseAddress = new Uri(baseAddress) });

await builder.Build().RunAsync();
