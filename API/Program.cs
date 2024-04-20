using Application.DTO.Config;
using Application.Interfaces;
using Application.UseCase.Services;
using Infraestructure.Command;
using Infraestructure.Persistence;
using Infraestructure.Query;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddNewtonsoftJson();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1.0.0",
        Title = "UserManagementMS",
        Description = "Basic architecture of the project.",
        Contact = new OpenApiContact
        {
            Name = "MatchMyJob",
            Url = new Uri("https://github.com/MatchMyJob/UserManagementMS")
        }
    });

    //Swagger Documentation
    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
});


//Custom
var connectionString = builder.Configuration["ConnectionString"];

builder.Services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(connectionString));

builder.Services.AddScoped<IApplicantCommand, ApplicantCommand>();
builder.Services.AddScoped<IApplicantQuery, ApplicantQuery>();
builder.Services.AddScoped<IApplicantCommandService, ApplicantCommandService>();
builder.Services.AddScoped<IApplicantQueryService, ApplicantQueryService>();

builder.Services.AddScoped<ICompanyCommand, CompanyCommand>();
builder.Services.AddScoped<ICompanyQuery, CompanyQuery>();
builder.Services.AddScoped<ICompanyCommandService, CompanyCommandService>();
builder.Services.AddScoped<ICompanyQueryService, CompanyQueryService>();

builder.Services.AddScoped<IContactInformationCommand, ContactInformationCommand>();
builder.Services.AddScoped<IContactInformationQuery, ContactInformationQuery>();
builder.Services.AddScoped<IContactInformationCommandService, ContactInformationCommandService>();
builder.Services.AddScoped<IContactInformationQueryService, ContactInformationQueryService>();

builder.Services.AddScoped<IProvinceQuery, ProvinceQuery>();
builder.Services.AddScoped<IProvinceService, ProvinceService>();


builder.Services.Configure<ApiBehaviorOptions>(options =>
{
    options.SuppressModelStateInvalidFilter = true;
});

builder.Services.AddCors(options =>
{
    options.AddPolicy("NewPolicy", app =>
    {
        app.AllowAnyOrigin()
           .AllowAnyMethod()
           .AllowAnyHeader();
    });
});



//Mapper
var config = new AutoMapper.MapperConfiguration(
    options =>
    {
        options.AllowNullDestinationValues = true;
        options.AllowNullCollections = true;
        options.AddProfile(new AutoMapperProfile());
    });
builder.Services.AddSingleton(config.CreateMapper());

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
