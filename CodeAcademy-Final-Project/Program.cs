using CodeAcademy_Final_Project;
using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration;
builder.Services.Register(config);



var app = builder.Build();

app.MapControllerRoute(
    "default",
    "{controller=home}/{action=index}/{id?}"
    );
app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(
            Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images")),
    RequestPath = "/images",
    ServeUnknownFileTypes = true, // Allow serving unknown file types, including .avif
    DefaultContentType = "image/avif", // Set the default content type for .avif files
});
app.UseAuthentication();
app.UseAuthorization();

app.UseStaticFiles();
app.Run();
