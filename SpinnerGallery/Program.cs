using Microsoft.Extensions.Hosting;
using RazorConsole.Core;
using SpinnerGallery;

Console.OutputEncoding = System.Text.Encoding.UTF8;
var hostBuilder = Host.CreateDefaultBuilder()
                      .UseRazorConsole<Gallery>();
var host = hostBuilder.Build();
await host.RunAsync();