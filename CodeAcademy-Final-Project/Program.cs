using CodeAcademy_Final_Project;
using Microsoft.Extensions.FileProviders;
using System.Reflection;


var rootPath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
Directory.SetCurrentDirectory(rootPath);
Console.WriteLine(rootPath);
var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration;
builder.Services.Register(config);

//builder.Logging.AddConsole();

var app = builder.Build();

app.UseStaticFiles();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllerRoute(
           name: "areas",
           pattern: "{area:exists}/{controller=dashboard}/{action=Index}/{id?}"
         );
app.MapControllerRoute(
    "default",
    "{controller=bookhome}/{action=index}/{id?}"
    );

app.UseStaticFiles();
app.Run();