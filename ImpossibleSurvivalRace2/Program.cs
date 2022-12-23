using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.ResponseCompression;
using ImpossibleSurvivalRace2.Server.Hubs;
using ImpossibleSurvivalRace2.Services;
using ImpossibleSurvivalRace2.DesignPattern;
using ImpossibleSurvivalRace2.Shared.Models;

//strategy
Console.WriteLine("Strategy pattern testing");
MovingObstacle move = new MovingObstacle(new WanderingMovement());
move.ExecuteStrategy();
move = new MovingObstacle(new CircleMovement());
move.ExecuteStrategy();
move = new MovingObstacle(new StrafeMovement());
move.ExecuteStrategy();
move = new MovingObstacle(new SlowStrafeMovement());
move.ExecuteStrategy();

//prototype
Console.WriteLine("Prototype pattern testing");
List<Fuel> fuelManager = new List<Fuel>();
LowValueTank oneLow = new LowValueTank(10);
LowValueTank twoLow = new LowValueTank(5);
HighValueTank oneHigh=new HighValueTank(40);
HighValueTank twoHigh = new HighValueTank(60);

LowValueTank oneLowCloned = oneLow.Clone() as LowValueTank;
LowValueTank twoLowCloned = twoLow.Clone() as LowValueTank;
HighValueTank oneHighCloned = oneHigh.Clone() as HighValueTank;
HighValueTank twoHighCloned = twoHigh.Clone() as HighValueTank;

// ------------ Factory method
Console.WriteLine();
List<Garage> garages = new List<Garage>();
garages.Add(new CarGarage());
garages.Add(new TankGarage());

foreach(Garage garage in garages)
{
    Vehicle vehicle = garage.Build();
    Console.WriteLine($"Built {vehicle.GetType().Name}");
}
// ------------

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<ILobbyService, LobbyService>();

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
