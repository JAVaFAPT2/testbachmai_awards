using MongoDB.Driver;
using TestHsAPI.service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var mongoConnectionString = builder.Configuration.GetConnectionString("MongoDb");
if (string.IsNullOrEmpty(mongoConnectionString))
{
    throw new InvalidOperationException("MongoDB connection string is not configured.");
}

var mongoClient = new MongoClient(mongoConnectionString);
var database = mongoClient.GetDatabase("YourDatabaseName");

builder.Services.AddSingleton<IMongoClient>(mongoClient);
builder.Services.AddSingleton(database);



var app = builder.Build();

builder.Services.AddSingleton<DiscountService>();
builder.Services.AddSingleton<HSService>();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

app.Run();
