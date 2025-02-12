using Microsoft.Extensions.DependencyInjection;
using test1.Data;
using test1.models;
using test1.models.IRepository;

var builder = WebApplication.CreateBuilder(args);

// Configure MongoDB settings
builder.Services.Configure<MongoDBSettings>(
    builder.Configuration.GetSection("award_bachmai_Database"));

// Register MongoDbContext
builder.Services.AddSingleton<MongoDbContext>();

// Register the repository
builder.Services.AddScoped<IPersonsRepository, PersonsRepository>();

// Add controllers
builder.Services.AddControllers();

// Add OpenAPI support
builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();