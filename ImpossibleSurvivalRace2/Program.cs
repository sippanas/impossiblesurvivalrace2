using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.ResponseCompression;
using ImpossibleSurvivalRace2.Server.Hubs;
using ImpossibleSurvivalRace2.Services;
using ImpossibleSurvivalRace2.DesignPattern;

MovementContext move = new MovementContext(new WanderingMovement());
move.ExecuteStrategy();
move = new MovementContext(new CircleMovement());
move.ExecuteStrategy();
move = new MovementContext(new StrafeMovement());
move.ExecuteStrategy();
move = new MovementContext(new SlowStrafeMovement());
move.ExecuteStrategy();

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddResponseCompression(options =>
{
    options.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(new[] { "application/octet-stream" });
});

var app = builder.Build();

app.UseResponseCompression();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapHub<GameHub>("/gamehub");
app.MapFallbackToPage("/_Host");

app.Run();
