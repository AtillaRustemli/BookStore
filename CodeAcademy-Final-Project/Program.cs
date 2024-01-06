using CodeAcademy_Final_Project;
using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration;
builder.Services.Register(config);



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
