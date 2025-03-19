using System.Reflection;
using Aplication.service.HumanData.Commands;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Domain.Interface;
using Infastructure.Persitance;
using Infastructure.Persitance.DbContext;
using Infastructure.Persitance.repository;
using Infastructure.Security;
using MediatR;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Use Autofac as the service provider
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());

// Register your services with Autofac
builder.Host.ConfigureContainer<ContainerBuilder>(containerBuilder =>
{
    // Register your application services
    containerBuilder.RegisterType<BachAwardDbContext>()
        .AsSelf()
        .WithParameter("connectionString",
            builder.Configuration.GetConnectionString("MongoDB") ?? throw new InvalidOperationException());

    // Register repositories
    containerBuilder.RegisterType<PersonRepository>().As<IPersonRepository>();

    // Register MediatR handlers from the Application assembly
    containerBuilder.RegisterAssemblyTypes(typeof(CreatePersonCommand).Assembly)
        .AsClosedTypesOf(typeof(IRequestHandler<,>))
        .InstancePerLifetimeScope();

    // Optionally, if you have other handlers in different assemblies:
    containerBuilder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
        .AsClosedTypesOf(typeof(IRequestHandler<,>))
        .InstancePerLifetimeScope();
});
// Configure MySQL DbContext
builder.Services.AddDbContext<MySqlDbContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("MySqlConnection"),
        new MySqlServerVersion(new Version(8, 0, 21))));


// Add services to the container.
builder.Services.AddControllers();

// Register MediatR
builder.Services.AddMediatR(cfg => { cfg.RegisterServicesFromAssemblies(AppDomain.CurrentDomain.GetAssemblies()); });
builder.Services.AddCustomCors("http://localhost:4200");
// Register class maps for Bson serialization
BsonClassMapConfig.RegisterClassMaps();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
    app.UseDeveloperExceptionPage();
else
    app.UseExceptionHandler(); // Use custom error handler in production


app.UseHttpsRedirection();


app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    var controllerActionEndpointConventionBuilder = endpoints.MapControllers(); // Map controllers for API endpoints
});

app.Run();