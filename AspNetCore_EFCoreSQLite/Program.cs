using AspNetCore_EFCoreInMemory.Helpers;
using AutoMapper;
using CrossCutting.Mappings;
using Data.Context;
using Data.Repository;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services.Post;
using Domain.Interfaces.Services.Usuario;
using Microsoft.EntityFrameworkCore;
using Service.Services;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connection = builder.Configuration["ConnectionStrings:DefaultConnection"];
builder.Services.AddDbContext<ApiContext>(opt => opt.UseSqlite(connection), ServiceLifetime.Singleton);

builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

builder.Services.AddTransient<IUsuarioService, UsuarioService>();
builder.Services.AddTransient<IPostService, PostService>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));

var config = new AutoMapper.MapperConfiguration(cfg =>
{
    cfg.AddProfile(new DtoToModelProfile());
    cfg.AddProfile(new EntityToDtoProfile());
    cfg.AddProfile(new ModelToEntityProfile());
});

IMapper mapper = config.CreateMapper();
builder.Services.AddSingleton(mapper);

builder.Services.AddControllers().AddJsonOptions(x =>
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

var context = app.Services.GetService<ApiContext>();
HelpContext.Configure(app.Services.GetRequiredService<IHttpContextAccessor>(), app.Configuration, context);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
