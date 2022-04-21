using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.AspNetCore.HttpOverrides;
using Tailwind;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseForwardedHeaders(new ForwardedHeadersOptions
{
    ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
});

if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

var clientRoot = "/wwwroot";
app.UseBlazorFrameworkFiles(clientRoot);
app.UseStaticFiles(clientRoot);

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile(clientRoot + "/index.html");

// Start Tailwind CSS hot reloading
if (app.Environment.IsDevelopment())
{
    app.RunTailwind("tailwind", "../Client/");
}

app.Run();
