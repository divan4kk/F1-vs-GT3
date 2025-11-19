using F1vsGT3Web;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<F1vsGT3Web.App>("#app"); // зверни увагу на простір імен

builder.Services.AddSingleton<TrackService>();

await builder.Build().RunAsync();
