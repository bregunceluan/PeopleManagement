using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using PeopleManagement.Web;
using PeopleManagement.Web.Services;
using PeopleManagement.Web.Services.Interfaces;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Logging.Services.AddLogging();


builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)});
builder.Services.AddScoped<IUserService, UserService>();

var host = builder.Build();

var logger = host.Services.GetRequiredService<ILoggerFactory>()
    .CreateLogger<Program>();


logger.LogDebug("dsfasdfasdfasdfasdfasdhsdfgbxfd354r34t5w43eghse");

await host.RunAsync();


