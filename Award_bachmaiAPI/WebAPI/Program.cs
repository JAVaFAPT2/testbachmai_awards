using System.Configuration;
using System.Reflection;
using System.Text;
using Aplication.service.HumanData.Commands;
using Autofac;
using Autofac.Core;
using Autofac.Extensions.DependencyInjection;
using Domain.Interface;
using Infastructure.Persitance;
using Infastructure.Persitance.DbContext;
using Infastructure.Persitance.repository;
using Infastructure.Security;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);

// Use Autofac as the service provider
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());

// Register your services with Autofac
builder.Host.ConfigureContainer<ContainerBuilder>(containerBuilder =>
{
    // Register your application services
    //containerBuilder.RegisterType<BachAwardDbContext>()
    //    .AsSelf()
    //    .WithParameter("connectionString",
    //        builder.Configuration.GetConnectionString("MongoDB") ?? throw new InvalidOperationException());

    // Register repositories
    containerBuilder.RegisterType<PersonRepository>().As<IPersonRepository>();
    containerBuilder.RegisterType<AuthRepository>().As<IAuthRepository>();

    // Register MediatR handlers from the Application assembly
    containerBuilder.RegisterAssemblyTypes(typeof(CreatePersonCommand).Assembly)
        .AsClosedTypesOf(typeof(IRequestHandler<,>))
        .InstancePerLifetimeScope();
    containerBuilder.RegisterAssemblyTypes(typeof(RegisterCommand).Assembly)
        .AsClosedTypesOf(typeof(IRequestHandler<,>))
        .InstancePerLifetimeScope();

    // Optionally, if you have other handlers in different assemblies:
    containerBuilder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
        .AsClosedTypesOf(typeof(IRequestHandler<,>))
        .InstancePerLifetimeScope();

});
// Configure MySQL DbContext
//builder.Services.AddDbContext<MySqlDbContext>(options =>
//    options.UseMySql(builder.Configuration.GetConnectionString("MySqlConnection"),
//        new MySqlServerVersion(new Version(8, 0, 21))));



builder.Services.AddDbContext<WebAPIContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("WebAPIContext")));


var key = Encoding.ASCII.GetBytes("Jwt:Key");
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    options.RequireHttpsMetadata = false;
    options.SaveToken = true;
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = false,
        ValidateAudience = false,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(key)
    };
});

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