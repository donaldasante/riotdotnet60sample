global using FastEndpoints;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using VueCliMiddleware;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSpaStaticFiles(opt => opt.RootPath = "ClientApp/public");
builder.Services.AddFastEndpoints();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseStaticFiles();

if (!app.Environment.IsDevelopment())
{
    app.UseSpaStaticFiles();
}

app.UseRouting();

app.UseAuthorization();

app.UseFastEndpoints();


app.UseSpa(spa =>
{
    spa.Options.SourcePath = "ClientApp";

    if (app.Environment.IsDevelopment())
    {
        spa.UseVueCli(
            npmScript: (System.Diagnostics.Debugger.IsAttached || app.Environment.IsDevelopment()) ? "start" : null,
            regex: "runtime modules",
            forceKill: true
         );
    }
});

app.Run();
