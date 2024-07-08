using FilmAPI.Data;
using FilmAPI.Services.Interfaces;
using FilmAPI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using FilmAPI.Data.Contexts;
using FilmAPI.Services.Classes;

var builder = WebApplication.CreateBuilder(args);

// Добавление служб в контейнер
builder.Services.AddControllers();

// Настройка DbContext с использованием строки подключения из appsettings.json
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));

// Регистрация сервиса MovieService
builder.Services.AddScoped<IMovieService, MovieService>();

// Настройка Swagger
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
    // Если у вас есть комментарии XML, добавьте их
    var xmlFile = $"{System.Reflection.Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    c.IncludeXmlComments(xmlPath);
});

var app = builder.Build();

// Конфигурация HTTP-запросов
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
        c.RoutePrefix = string.Empty; // Устанавливает Swagger UI на корень приложения
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
