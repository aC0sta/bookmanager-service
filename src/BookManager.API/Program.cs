using BookManager.Domain.Interfaces.Cache;
using BookManager.Domain.Interfaces.Repository;
using BookManager.Domain.Interfaces.Services;
using BookManager.Infrastructure.Cache;
using BookManager.Infrastructure.Repository;
using BookManager.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Dependecy Injection
builder.Services.AddScoped<IBookRepository, BookRepository>(); //aqui que ele pega aonde esta a implementacao
builder.Services.AddScoped<ICache, Cache>();
builder.Services.AddLogging();
builder.Services.AddHttpClient();

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

// Por favor Visual studio não quebra não
// Nunca te pedi nada

// Se você rodar eu te pago DEIZÃO, DEIZÃO FI