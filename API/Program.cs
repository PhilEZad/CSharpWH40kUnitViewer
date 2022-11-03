using Application.DTOs;
using AutoMapper;
using Domain;
using FluentValidation;
using Infrastructure;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Database File
builder.Services.AddDbContext<DatabaseContext>(options => options.UseSqlite(
    "Data Source=db.db"));

//Fluent Validation Injection
builder.Services.AddValidatorsFromAssemblies(AppDomain.CurrentDomain.GetAssemblies());

//Register
Application.DependencyResolver.DependencyResolverService.RegisterApplicationLayer(builder.Services);
Infrastructure.DependencyResolver.DependencyResolverService.RegisterInfrastructureLayer(builder.Services);

//DTO Mapper
var mapper = new MapperConfiguration(config =>
{
    config.CreateMap<UnitDTO, Unit>();
}).CreateMapper();
builder.Services.AddSingleton(mapper);

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