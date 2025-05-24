using Forum.API.Extention;
using Forum.Persistence.Extensions;
using Forum.Application.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.RegisterRepositories();
builder.Services.RegisterDatabaseConnection(builder.Configuration);
builder.Services.RegisterAutoMapper();
builder.Services.RegisterMediatr();

var app = builder.Build();

app.MapDefaultEndpoints();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.MapOpenApi();
}

app.RegisterScalar();

app.UseAuthorization();

app.MapControllers();

app.Run();
